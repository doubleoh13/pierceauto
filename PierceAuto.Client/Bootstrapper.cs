using System.ComponentModel;
using System.Windows;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Caliburn.Micro;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PierceAuto.Client.DataAccess;
using PierceAuto.Client.Framework;
using PierceAuto.Client.Services.DataAccess;
using PierceAuto.Client.Utils;
using PierceAuto.Client.ViewModels;
using IContainer = Autofac.IContainer;

namespace PierceAuto.Client;

internal class Bootstrapper : BootstrapperBase
{
    private IContainer _container = null!;
    private IServiceProvider _serviceProvider = null!;

    public Bootstrapper()
    {
        LogManager.GetLog = type => new DebugLog(type);
        Initialize();
    }

    protected override async void OnStartup(object sender, StartupEventArgs e)
    {
        await DisplayRootViewForAsync<ShellViewModel>();
    }

    protected override void OnExit(object sender, EventArgs e)
    {
        base.OnExit(sender, e);
    }

    protected override void Configure()
    {
        ConfigureContainer();
        LogManager.GetLog = type =>
        {
            using var scope = _container.BeginLifetimeScope();
            var loggerType = typeof(LoggingAdapter<>).MakeGenericType(type);
            return (ILog)scope.Resolve(loggerType);
        };
    }

    private static IConfigurationRoot LoadConfigOptions()
    {
        return new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .Build();
    }

    private async void ConfigureContainer()
    {
        var configuration = LoadConfigOptions();
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddLogging(builder => { builder.AddConsole(); });

        var builder = new ContainerBuilder();
        builder.Populate(serviceCollection);

        builder.Register(s =>
        {
            var options = new DbContextOptionsBuilder<PierceAutoDbContext>();
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new PierceAutoDbContext(options.Options);
        }).As<PierceAutoDbContext>().InstancePerDependency();

        // Register the ViewModels
        builder.RegisterAssemblyTypes(AssemblySource.Instance.ToArray())
            // Must be a type that ends in ViewModel
            .Where(type => type.Name.EndsWith("ViewModel"))
            .Where(type => !typeof(IWorkspace).IsAssignableFrom(type))
            // Must be in Namespace that ends in ViewModel
            .Where(type => (type.Namespace?.EndsWith("ViewModels") ?? false) ||
                           (type.Namespace?.StartsWith("PierceAuto.Client.ViewModels") ?? false))
            // Must implement INotifyPropertyChanged
            .Where(type => typeof(INotifyPropertyChanged).IsAssignableFrom(type))
            .AsSelf()
            .InstancePerDependency();

        // Register the Workspaces as Singletons
        builder.RegisterAssemblyTypes(AssemblySource.Instance.ToArray())
            .Where(type => typeof(IWorkspace).IsAssignableFrom(type))
            .AsSelf()
            .SingleInstance();

        // Register the Views
        builder.RegisterAssemblyTypes(AssemblySource.Instance.ToArray())
            // Must be a type that ends in View
            .Where(type => type.Name.EndsWith("View"))
            // Must be in Namespace that ends in Views
            .Where(type => (type.Namespace?.EndsWith("Views") ?? false) ||
                           (type.Namespace?.StartsWith("PierceAuto.Client.Views") ?? false))
            .AsSelf()
            .InstancePerDependency();

        builder.RegisterInstance(configuration).As<IConfiguration>().SingleInstance();
        builder.RegisterType<PierceAutoDbContextFactory>().AsSelf().SingleInstance();

        builder.RegisterType<ProductProvider>().SingleInstance();

        builder.RegisterType<WindowManager>().As<IWindowManager>();
        builder.RegisterType<EventAggregator>().As<IEventAggregator>();
        builder.RegisterGeneric(typeof(LoggingAdapter<>)).AsSelf().SingleInstance();

        List<IWorkspace> workspaces = [];
        builder.RegisterInstance(workspaces).As<IEnumerable<IWorkspace>>().SingleInstance();

        _container = builder.Build();

        await using var scope = _container.BeginLifetimeScope();
        var workspaceTypes = AssemblySource.Instance.SelectMany(x => x.GetTypes())
            .Where(x => typeof(IWorkspace).IsAssignableFrom(x) && !x.IsAbstract)
            .ToArray();

        foreach (var workspaceType in workspaceTypes)
        {
            if (!scope.IsRegistered(workspaceType))
                break;
            var workspace = (IWorkspace)scope.Resolve(workspaceType);
            workspaces.Add(workspace);
        }
    }

    protected override object GetInstance(Type service, string key)
    {
        using var scope = _container.BeginLifetimeScope();
        if (string.IsNullOrWhiteSpace(key) && scope.IsRegistered(service))
            return scope.Resolve(service);
        if (scope.IsRegisteredWithKey(key, service))
            return scope.ResolveKeyed(key, service);
        throw new Exception($"Could not locate any instances of contract {service.Name}.");
    }

    protected override IEnumerable<object> GetAllInstances(Type service)
    {
        var genericType = typeof(IEnumerable<>).MakeGenericType(service);
        using var scope = _container.BeginLifetimeScope();
        return (IEnumerable<object>)scope.Resolve(genericType);
    }

    protected override void BuildUp(object instance)
    {
        _container.InjectProperties(instance);
    }
}