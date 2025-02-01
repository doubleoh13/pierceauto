using Caliburn.Micro;

namespace PierceAuto.Client.Utils;

internal class ScreenBuilder<T> where T : IScreen
{
    public T Build()
    {
        return IoC.Get<T>();
    }
}