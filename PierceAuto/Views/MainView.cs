namespace PierceAuto.Views;

internal partial class MainView : Form, IMainView
{
    public MainView()
    {
        InitializeComponent();
        Load += LoadEvent;
    }

    public IMainMenu MainMenu { get; set; }
    public bool FindButtonEnabled { get => findToolStripButton.Enabled; set => findToolStripButton.Enabled = value; }
    public bool AddButtonEnabled { get => addToolStripButton.Enabled; set => addToolStripButton.Enabled = value; }

    public bool FirstRecordButtonEnabled
    {
        get => firstRecordToolStripButton.Enabled;
        set => firstRecordToolStripButton.Enabled = value;
    }

    public bool PreviousRecordButtonEnabled
    {
        get => previousRecordToolStripButton.Enabled;
        set => previousRecordToolStripButton.Enabled = value;
    }

    public bool NextRecordButtonEnabled
    {
        get => nextRecordToolStripButton.Enabled;
        set => nextRecordToolStripButton.Enabled = value;
    }

    public bool LastRecordButtonEnabled
    {
        get => lastRecordToolStripButton.Enabled;
        set => lastRecordToolStripButton.Enabled = value;
    }

    public bool RefreshButtonEnabled
    {
        get => refreshRecordToolStripButton.Enabled;
        set => refreshRecordToolStripButton.Enabled = value;
    }

    public event EventHandler? LoadEvent;
    public event EventHandler? FindButtonClickedEvent;
    public event EventHandler? AddButtonClickedEvent;
    public event EventHandler? FirstRecordButtonClickedEvent;
    public event EventHandler? PreviousRecordButtonClickedEvent;
    public event EventHandler? NextRecordButtonClickedEvent;
    public event EventHandler? LastRecordButtonClickedEvent;
    public event EventHandler? RefreshButtonClickedEvent;

    private void MainWindow_Load(object sender, EventArgs e)
    {
        findToolStripButton.Click += (s, args) => FindButtonClickedEvent?.Invoke(this, EventArgs.Empty);
        addToolStripButton.Click += (s, args) => AddButtonClickedEvent?.Invoke(this, EventArgs.Empty);
        firstRecordToolStripButton.Click += (s, args) => FirstRecordButtonClickedEvent?.Invoke(this, EventArgs.Empty);
        previousRecordToolStripButton.Click +=
            (s, args) => PreviousRecordButtonClickedEvent?.Invoke(this, EventArgs.Empty);
        nextRecordToolStripButton.Click += (s, args) => NextRecordButtonClickedEvent?.Invoke(this, EventArgs.Empty);
        lastRecordToolStripButton.Click += (o, args) => LastRecordButtonClickedEvent?.Invoke(this, EventArgs.Empty);
        refreshRecordToolStripButton.Click += (o, args) => RefreshButtonClickedEvent?.Invoke(this, EventArgs.Empty);
    }
}