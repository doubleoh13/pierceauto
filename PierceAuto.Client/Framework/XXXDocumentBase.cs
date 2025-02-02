using System.Windows;
using Caliburn.Micro;

namespace PierceAuto.Client.Framework;

internal abstract class XXXDocumentBase : Screen
{
    private bool _isDirty;

    public bool IsDirty
    {
        get => _isDirty;
        set
        {
            _isDirty = value;
            NotifyOfPropertyChange(() => IsDirty);
        }
    }

    public override async Task<bool> CanCloseAsync(CancellationToken cancellationToken = new())
    {
        return !IsDirty || await DoCloseCheck();
    }

    protected virtual async Task<bool> DoCloseCheck()
    {
        var result = MessageBox.Show(
            "You have unsaved data. Are you sure you want to close this document? All changes will be lost.",
            "Unsaved Data",
            MessageBoxButton.YesNo, MessageBoxImage.Stop, MessageBoxResult.No
        );

        return result == MessageBoxResult.Yes;
    }
}