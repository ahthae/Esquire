using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public partial class MainWindow : WindowBase<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        
        WeakReferenceMessenger.Default.Register<ShowDatabaseSettingsDialogMessage>(this, ShowDatabaseSettingsDialogHandler);
        WeakReferenceMessenger.Default.Register<ShowUserDialogMessage>(this, ShowUserDialogHandler);
    }

    private void ShowDatabaseSettingsDialogHandler(object? receiver, ShowDatabaseSettingsDialogMessage? message)
    {
        Show(); // Sometimes this handler is called while the window is hidden, and Avalonia throws an exception when showing a dialog from a hidden window
        new DatabaseSettingsWindow().ShowDialog(this);
    }

    private async void ShowUserDialogHandler(object? receiver, ShowUserDialogMessage? message)
    {
        Show();
        message.Reply(await new AnalysisModeUserDialogWindow().ShowDialog<string>(this));
    }
}