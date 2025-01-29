using Microsoft.Extensions.DependencyInjection;

namespace PierceAuto.Services;
internal class WindowFactory(IServiceProvider serviceProvider)
{
    public T CreateWindow<T>() where T : Form
    {
        var window = serviceProvider.GetRequiredService<T>();

        return window;
    }
}
