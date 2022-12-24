using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public partial class MainWindow : WindowBase<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        
        WeakReferenceMessenger.Default.Register<ShowUserDialogMessage>(this, ShowUserDialogHandler);
    }

    private async void ShowUserDialogHandler(object? receiver, ShowUserDialogMessage? message)
    {
        Show();
        message.Reply(await new AnalysisModeUserDialogWindow().ShowDialog<string>(this));
    }
}