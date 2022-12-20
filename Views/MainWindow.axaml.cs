using System;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.Views;

public partial class MainWindow : Window
{
    private SignOnWindow _signOnWindow;
    public MainWindow(IServiceProvider services)
    {
        InitializeComponent();
        _signOnWindow = new SignOnWindow(services) { DataContext = services.GetService<SignOnViewModel>() };
        _signOnWindow.Topmost = true;
        WeakReferenceMessenger.Default.Register<SignOnShowMessage>(this, ShowSignOnHandler);
    }

    private void ShowSignOnHandler(object? receiver, SignOnShowMessage? message)
    {
        Show();
        _signOnWindow.ShowDialog(this);
    }
}