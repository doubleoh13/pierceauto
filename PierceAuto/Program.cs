using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PierceAuto.Forms;
using PierceAuto.Presenters;
using PierceAuto.Repositories;
using PierceAuto.Services;
using PierceAuto.Views;

namespace PierceAuto;

internal static class Program
{
    private static IConfiguration Configuration { get; set; } = null!;
    private static IServiceProvider ServiceProvider { get; set; } = null!;

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        ConfigureSettings();
        ConfigureServices();

        ApplicationConfiguration.Initialize();
        var mainPresenter = ServiceProvider.GetRequiredService<MainPresenter>();

        Application.Run((Form)mainPresenter.View);
    }

    private static void ConfigureSettings()
    {
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
    }

    private static void ConfigureServices()
    {
        ServiceProvider = new ServiceCollection()
            .AddSingleton(Configuration)
            .AddSingleton<WindowFactory>()
            // Main Window
            .AddSingleton<MainPresenter>()
            .AddSingleton<IMainView, MainView>()
            // Main Menu
            .AddSingleton<IMainMenu, MainMenu>()
            // Product
            .AddSingleton<ProductPresenter>()
            .AddTransient<ProductRepository>()
            .AddTransient<IProductView, ProductView>()
            .AddSingleton<Func<IProductView>>(s => () => s.GetRequiredService<IProductView>())
            .BuildServiceProvider();
    }
}