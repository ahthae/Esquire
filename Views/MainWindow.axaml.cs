using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public partial class MainWindow : Window
{
    private SignOnWindow _signOnWindow;
    public MainWindow()
    {
        InitializeComponent();
        _signOnWindow = new SignOnWindow();
        _signOnWindow.Topmost = true;
        WeakReferenceMessenger.Default.Register<ShowSignOnMessage>(this, ShowSignOnHandler);
    }

    public async void ShowSignOnHandler(object? receiver, ShowSignOnMessage? message)
    {
        this.Show();
        _signOnWindow.ShowDialog(this);
    }
}