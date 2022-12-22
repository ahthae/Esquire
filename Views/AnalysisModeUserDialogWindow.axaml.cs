using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;
using System.Linq;

namespace esquire.Views;

public partial class AnalysisModeUserDialogWindow : Window
{
    public AnalysisModeUserDialogWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void OnInitialized(object? sender, EventArgs e)
    {
        WeakReferenceMessenger.Default.Send<GetDatabaseUsersMessage>();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Close((DataContext as AnalysisModeUserDialogViewModel)?.SelectedUser.Username); //TODO handle null SelectedUser
    }
}