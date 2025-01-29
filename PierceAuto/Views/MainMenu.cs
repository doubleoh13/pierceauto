using PierceAuto.Views;

namespace PierceAuto.Forms;

internal partial class MainMenu : Form, IMainMenu
{
    public MainMenu()
    {
        InitializeComponent();
    }

    public event EventHandler? ProductButtonClickedEvent;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        productsButton.Click += (_, _) => ProductButtonClickedEvent?.Invoke(this, EventArgs.Empty);
    }
}