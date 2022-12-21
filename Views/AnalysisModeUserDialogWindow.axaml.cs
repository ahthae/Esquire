using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

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

    private void UserDialog_OnActivated(object? sender, EventArgs e)
    {
        WeakReferenceMessenger.Default.Send<GetDatabaseUsersMessage>();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Close((DataContext as AnalysisModeUserDialogViewModel)?.SelectedUser.Username); //TODO handle null SelectedUser
    }

    private void UserSelection_OnPopulated(object? sender, PopulatedEventArgs e)
    {
        Console.WriteLine("Populated");
    }

    private void UserSelection_OnPopulating(object? sender, PopulatingEventArgs e)
    {
        Console.WriteLine("Populating");
    }
}