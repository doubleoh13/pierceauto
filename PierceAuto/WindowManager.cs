/*using PierceAuto.Forms;
using PierceAuto.Services;

namespace PierceAuto;

internal class WindowManager
{
    private readonly List<Form> _openWindows = [];

    private readonly WindowFactory _windowFactory;
    private MainView? _mainWindow;
    public Form? FocusedWindow;


    public WindowManager(WindowFactory windowFactory)
    {
        _windowFactory = windowFactory;
    }

    public MainView MainWindow => _mainWindow ??= _windowFactory.CreateWindow<MainView>();
    public event EventHandler<Form>? WindowClosed;
    public event EventHandler<Form>? FocusedWindowChanged;
    public event EventHandler<IForm>? FocusedWindowFormModeChanged;

    public T OpenWindow<T>() where T : Form
    {
        var window = _windowFactory.CreateWindow<T>();
        if (_openWindows.Contains(window))
        {
            return window;
        }

        window.FormClosed += (sender, e) => OnWindowClosed(window);

        window.Activated += (sender, e) => OnWindowActivated(window);
        window.Leave += (sender, e) => OnWindowLeave(window);
        if (window is IForm formWindow)
        {
            formWindow.FormModeChanged += (sender, e) => OnFocusedWindowFormModeChanged(formWindow);
        }

        window.MdiParent = MainWindow;
        window.Show();
        window.BringToFront();
        window.Activate();

        return window;
    }

    private void FormWindow_FormModeChanged(object? sender, FormMode e)
    {
        throw new NotImplementedException();
    }

    private void OnWindowClosed(Form window)
    {
        _openWindows.Remove(window);
        WindowClosed?.Invoke(this, window);
    }

    private void OnWindowActivated(Form window)
    {
        FocusedWindow = window;
        FocusedWindowChanged?.Invoke(this, window);
    }

    private void OnWindowLeave(Form window)
    {
        if (FocusedWindow != window)
        {
            return;
        }

        FocusedWindow = null;
        FocusedWindowChanged?.Invoke(this, null);
    }

    private void OnFocusedWindowFormModeChanged(IForm window)
    {
        if (FocusedWindow != window)
        {
            return;
        }

        FocusedWindowFormModeChanged?.Invoke(this, window);
    }
}*/

