using System;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.DependencyInjection;
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
}