using System;
using Avalonia;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public partial class AnalysisModeUserDialog : DialogBase<AnalysisModeViewModel>
{
    public AnalysisModeUserDialog()
    {
        WeakReferenceMessenger.Default.Register<AnalysisModeUserDialogCloseMessage>(this, DialogCloseMessageHandler);
        
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
                Close(viewModel.SelectedUser.UserId);
            else
                Close();
        });
    }
}