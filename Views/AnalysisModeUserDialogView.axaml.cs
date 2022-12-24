using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public partial class AnalysisModeUserDialogView : UserControl
{
    private readonly string _dialogIdentifier = "QueryDialog";
    private DialogHost.DialogSession? _dialog;
    
    public AnalysisModeUserDialogView()
    {
        WeakReferenceMessenger.Default.Register<ConfirmDatabaseUserMessage>(this, ConfirmDatabaseUserHandler);
        WeakReferenceMessenger.Default.Register<AnalysisModeUserDialogCloseMessage>(this, OnClose);
        
        InitializeComponent();
    }

    private void OnClose(object? recipient, AnalysisModeUserDialogCloseMessage message)
    {
        _dialog.Close();
    }

    private void ConfirmDatabaseUserHandler(object? sender, ConfirmDatabaseUserMessage message)
    {
        var viewModel = DataContext as AnalysisModeUserDialogViewModel;
        if (viewModel?.SelectedUser is not null)
            _dialog.Close(viewModel.SelectedUser.UserId);
        else
            _dialog.Close();
    }
    private void Visual_OnAttachedToVisualTree(object? sender, VisualTreeAttachmentEventArgs e)
    {
        Console.WriteLine("Attaching");
        _dialog = DialogHost.DialogHost.GetDialogSession(_dialogIdentifier)!;
        WeakReferenceMessenger.Default.Send<GetDatabaseUsersMessage>();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}