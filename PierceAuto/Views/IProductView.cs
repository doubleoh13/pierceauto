using PierceAuto.Views;

namespace PierceAuto.Forms;

internal interface IProductView : IChildView
{
    string ID { get; set; }
    string SKU { get; set; }
    string Description { get; set; }

    FormMode Mode { get; set; }
    string Button1Text { set; }

    event EventHandler OkayEvent;
    event EventHandler CancelEvent;
}