using System;
using Avalonia;
using Avalonia.Controls;
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

    private void OnInitialized(object? sender, EventArgs e)
    {
        WeakReferenceMessenger.Default.Send<GetDatabaseUsersMessage>();
        WeakReferenceMessenger.Default.Register<ConfirmDatabaseUserMessage>(this, (r, m) =>
        {
            var viewModel = DataContext as AnalysisModeUserDialogViewModel;
            if (viewModel?.SelectedUser is not null)
                Close(viewModel.SelectedUser.Username);
            else
                Close();
        });
    }
}