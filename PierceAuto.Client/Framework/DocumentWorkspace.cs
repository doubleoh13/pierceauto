using System.ComponentModel;
using Caliburn.Micro;

namespace PierceAuto.Client.Framework;

internal abstract class DocumentWorkspace<TDocument> : Conductor<TDocument>.Collection.OneActive, IDocumentWorkspace
    where TDocument : class, INotifyPropertyChanged, IDeactivate, IHaveDisplayName
{
    private DocumentWorkspaceState _state = DocumentWorkspaceState.Master;

    protected DocumentWorkspace()
    {
        Items.CollectionChanged += delegate { NotifyOfPropertyChange(() => Status); };
        DisplayName = IconName;
    }

    public DocumentWorkspaceState State
    {
        get => _state;
        set
        {
            if (_state == value)
                return;

            _state = value;
            NotifyOfPropertyChange(() => State);
        }
    }

    protected IConductor Conductor => (IConductor)Parent;

    public abstract string Icon { get; }
    public abstract string IconName { get; }
    public string Status => Items.Count > 0 ? Items.Count.ToString() : string.Empty;

    async Task IDocumentWorkspace.Edit(object document)
    {
        await Edit((TDocument)document);
    }

    public string NavigationName { get; }

    public async Task Show()
    {
        if (Parent is IHaveActiveItem haveActive && haveActive.ActiveItem == this)
        {
            DisplayName = IconName;
            State = DocumentWorkspaceState.Master;
        }
        else
        {
            await Conductor.ActivateItemAsync(this);
        }
    }

    public async Task Edit(TDocument child)
    {
        await Conductor.ActivateItemAsync(this);
        State = DocumentWorkspaceState.Detail;
        DisplayName = child.DisplayName;
        await ActivateItemAsync(child);
    }

    public override async Task ActivateItemAsync(TDocument item, CancellationToken cancellationToken = new())
    {
        item.Deactivated += OnItemOnDeactivated;
        item.PropertyChanged += OnItemPropertyChanged;

        await base.ActivateItemAsync(item, cancellationToken);
    }

    private void OnItemPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "DisplayName" && sender is TDocument document)
            DisplayName = document.DisplayName;
    }

    private Task OnItemOnDeactivated(object sender, DeactivationEventArgs e)
    {
        var doc = (TDocument)sender;
        if (e.WasClosed)
        {
            DisplayName = IconName;
            State = DocumentWorkspaceState.Master;
            doc.Deactivated -= OnItemOnDeactivated;
            doc.PropertyChanged -= OnItemPropertyChanged;
        }

        return Task.CompletedTask;
    }
}