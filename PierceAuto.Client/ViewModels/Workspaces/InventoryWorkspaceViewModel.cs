using Caliburn.Micro;
using JetBrains.Annotations;
using PierceAuto.Client.Framework;
using PierceAuto.Client.Models;
using PierceAuto.Client.Services.DataAccess;

namespace PierceAuto.Client.ViewModels.Workspaces;

[UsedImplicitly]
internal class InventoryWorkspaceViewModel(ProductViewModel.Factory productViewModelFactory)
    : Conductor<IInventoryWorkspaceSubview>.Collection.OneActive, IWorkspace
{
    public required ProductProvider ProductProvider { get; init; }

    public IObservableCollection<Product> Products { get; } = new BindableCollection<Product>();
    public string NavigationName { get; } = "Inventory";

    protected override void OnViewReady(object view)
    {
        base.OnViewReady(view);
        LoadProducts();
    }

    private async Task LoadProducts()
    {
        var products = await ProductProvider.GetAll();
        Products.Clear();
        Products.AddRange(products);
    }

    public async Task StartNewProduct()
    {
        var view = productViewModelFactory.Invoke();
        await ActivateItemAsync(view);
    }
}