using System;
using System.Collections;
using System.Threading.Tasks;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.Views;

public partial class MainWindow : Window
{
    private readonly IServiceProvider _serviceProvider;
    public MainWindow(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
        WeakReferenceMessenger.Default.Register<SignOnShowMessage>(this, ShowSignOnHandler);
        WeakReferenceMessenger.Default.Register<ShowUserDialogMessage>(this, ShowUserDialogHandler);
    }

    private void ShowSignOnHandler(object? receiver, SignOnShowMessage? message)
    {
        Show(); // Sometimes this handler is called while the window is hidden, and Avalonia throws an exception when showing a dialog from a hidden window
        new SignOnWindow(_serviceProvider)
        {
            DataContext = _serviceProvider.GetService<SignOnViewModel>(),
            Topmost = true
        }.ShowDialog(this);
    }

    private async void ShowUserDialogHandler(object? receiver, ShowUserDialogMessage? message)
    {
        Show();
        message.Reply(await new AnalysisModeUserDialogWindow()
        {
            DataContext = _serviceProvider.GetService<AnalysisModeUserDialogViewModel>()
        }.ShowDialog<string>(this));
    }
}