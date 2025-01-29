namespace PierceAuto.Forms;

delegate T CreateForm<out T>() where T : IForm;

enum FormMode
{
    Find,
    Ok,
    Update,
    Add,
}

internal interface IForm
{
    event EventHandler<FormMode> FormModeChanged;
    FormMode FormMode { get; }

    bool CanFind { get; }
    bool CanAdd { get; }
    bool IsNavigable { get; }
    void GoToFindMode();
    void GoToAddMode();
    void GoToFirstRecord();
    void GoToPreviousRecord();
    void GoToNextRecord();
    void GoToLastRecord();
    void RefreshRecord();
}
