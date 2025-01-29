using PierceAuto.Forms;
using PierceAuto.Views;

namespace PierceAuto.Presenters;

internal class MainPresenter
{
    private readonly List<IChildView> _childViews = [];
    private readonly IMainMenu _mainMenu;
    private readonly Func<IProductView> _productViewFactory;
    private IChildView? _focusedChildView;

    public MainPresenter(IMainView view, IMainMenu mainMenu, Func<IProductView> productViewFactory)
    {
        View = view;
        _mainMenu = mainMenu;
        _productViewFactory = productViewFactory;

        // Main View Events
        View.LoadEvent += (_, _) => EnableOrDisableRecordToolbarButtons();
        View.LoadEvent += (_, _) => ((Form)_mainMenu).Show();
        View.FindButtonClickedEvent += (_, _) => FindButtonClickedAction();
        View.AddButtonClickedEvent += (_, _) => AddButtonClickedAction();
        View.FirstRecordButtonClickedEvent += (_, _) => FirstButtonClickedAction();
        View.PreviousRecordButtonClickedEvent += (_, _) => PreviousButtonClickedAction();
        View.NextRecordButtonClickedEvent += (_, _) => NextButtonClickedAction();
        View.LastRecordButtonClickedEvent += (_, _) => LastButtonClickedAction();
        View.RefreshButtonClickedEvent += (_, _) => RefreshButtonClickedAction();

        // Main Menu Events
        _mainMenu.ProductButtonClickedEvent += (_, _) => OpenNewView<IProductView>();
    }

    public IMainView View { get; }

    public IChildView? FocusedChildView
    {
        get => _focusedChildView;
        set
        {
            _focusedChildView = value;
            OnFocusedChildViewChange();
        }
    }

    private void OnFocusedChildViewChange()
    {
        throw new NotImplementedException();
    }

    private void OpenNewView<T>() where T : IChildView
    {
        IProductView view = typeof(T) switch
        {
            var t when t == typeof(IProductView) => _productViewFactory(),
            _ => throw new NotImplementedException($"View not implemented. {typeof(T).Name}")
        };

        view.MdiParent = (Form)View;
        _childViews.Add(view);
        ((Form)view).GotFocus += (_, _) => _focusedChildView = view;
        ((Form)view).LostFocus += (_, _) =>
        {
            if (view == _focusedChildView)
            {
                _focusedChildView = null;
            }
        };
        ((Form)view).FormClosed += (_, _) => _childViews.Remove(view);
    }

    private void RefreshButtonClickedAction()
    {
        throw new NotImplementedException();
    }

    private void LastButtonClickedAction()
    {
        throw new NotImplementedException();
    }

    private void NextButtonClickedAction()
    {
        throw new NotImplementedException();
    }

    private void PreviousButtonClickedAction()
    {
        throw new NotImplementedException();
    }

    private void FirstButtonClickedAction()
    {
        throw new NotImplementedException();
    }

    private void AddButtonClickedAction()
    {
        throw new NotImplementedException();
    }

    private void FindButtonClickedAction()
    {
        throw new NotImplementedException();
    }

    private void FocusedChildViewChangedAction()
    {
        throw new NotImplementedException();
    }

    private void EnableOrDisableRecordToolbarButtons()
    {
        if (_focusedChildView is null)
        {
            DisableRecordToolbarButtons();
        }
    }

    private void DisableRecordToolbarButtons()
    {
        View.FindButtonEnabled = false;
        View.AddButtonEnabled = false;
        View.FirstRecordButtonEnabled = false;
        View.PreviousRecordButtonEnabled = false;
        View.NextRecordButtonEnabled = false;
        View.LastRecordButtonEnabled = false;
        View.RefreshButtonEnabled = false;
    }
}