using PierceAuto.Forms;
using PierceAuto.Repositories;

namespace PierceAuto.Presenters;

internal class ProductPresenter
{
    private IProductRepository _repository;
    private readonly IProductView _view;

    public ProductPresenter(IProductView view, IProductRepository repository)
    {
        _view = view;
        _repository = repository;
        _view.OkayEvent += OkayAction;
        _view.CancelEvent += CancelAction;
    }

    private void CancelAction(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OkayAction(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}