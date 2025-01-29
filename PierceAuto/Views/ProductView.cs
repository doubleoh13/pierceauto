namespace PierceAuto.Forms;

internal partial class ProductView : Form, IProductView
{
    public ProductView()
    {
        InitializeComponent();
    }

    public string ID { get; set; }
    public string SKU { get => txtSKU.Text; set => txtSKU.Text = value; }
    public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
    public string Button1Text { set => btn1.Text = value; }

    public FormMode Mode { get; set; }

    public event EventHandler? OkayEvent;
    public event EventHandler? CancelEvent;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        btn1.Click += (_, _) => OkayEvent?.Invoke(this, EventArgs.Empty);
        btn2.Click += (_, _) => CancelEvent?.Invoke(this, EventArgs.Empty);
    }
}