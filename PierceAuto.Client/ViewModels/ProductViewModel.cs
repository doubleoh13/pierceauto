using Caliburn.Micro;
using PierceAuto.Client.Framework;

namespace PierceAuto.Client.ViewModels;

internal class ProductViewModel : Screen, IInventoryWorkspaceSubview
{
    public delegate ProductViewModel Factory();
}