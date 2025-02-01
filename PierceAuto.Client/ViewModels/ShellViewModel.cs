using Caliburn.Micro;
using Microsoft.Extensions.Logging;
using PierceAuto.Client.Framework;

namespace PierceAuto.Client.ViewModels;

internal class ShellViewModel : Conductor<IWorkspace>.Collection.OneActive
{
    public ShellViewModel(IEnumerable<IWorkspace> workspaces)
    {
        Items.AddRange(workspaces);
    }

    public IWorkspace? SelectedItem
    {
        get => ActiveItem;
        set
        {
            if (value is null) return;
            Navigate(value);
        }
    }

    public ILogger<ShellViewModel> Logger { private get; init; } = null!;


    public async void Navigate(IWorkspace? workspace)
    {
        try
        {
            await ActivateItemAsync(workspace);
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Error activating workspace");
        }
    }
}