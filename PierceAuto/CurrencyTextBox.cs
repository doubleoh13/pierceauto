using System.Globalization;

namespace PierceAuto;

internal sealed class CurrencyTextBox : TextBox
{
    public CurrencyTextBox()
    {
        TextAlign = HorizontalAlignment.Right;
        Text = "0.00";
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }

        if (e.KeyChar == '.' && Text.Contains('.'))
        {
            e.Handled = true;
        }
        base.OnKeyPress(e);
    }

    protected override void OnLeave(EventArgs e)
    {
        if (decimal.TryParse(Text, out decimal result))
        {
            Text = result.ToString("C", CultureInfo.CurrentCulture);
        }
        else
        {
            Text = "0.00";
        }
        
        base.OnLeave(e);
    }
}