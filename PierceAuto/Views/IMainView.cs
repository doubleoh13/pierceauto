namespace PierceAuto.Views;

internal interface IMainView
{
    IMainMenu MainMenu { get; set; }

    bool FindButtonEnabled { get; set; }
    bool AddButtonEnabled { get; set; }
    bool FirstRecordButtonEnabled { get; set; }
    bool PreviousRecordButtonEnabled { get; set; }
    bool NextRecordButtonEnabled { get; set; }
    bool LastRecordButtonEnabled { get; set; }
    bool RefreshButtonEnabled { get; set; }

    event EventHandler LoadEvent;
    event EventHandler FindButtonClickedEvent;
    event EventHandler AddButtonClickedEvent;
    event EventHandler FirstRecordButtonClickedEvent;
    event EventHandler PreviousRecordButtonClickedEvent;
    event EventHandler NextRecordButtonClickedEvent;
    event EventHandler LastRecordButtonClickedEvent;
    event EventHandler RefreshButtonClickedEvent;
}