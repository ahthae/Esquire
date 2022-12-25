using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public partial class AnalysisModeUserDialogView : UserControl
{
    private const string DialogIdentifier = "QueryDialog";
    
    public AnalysisModeUserDialogView()
    {
        //DialogHost.Avalonia discards viewmodels
        DataContext = App.Current.Services.GetService(typeof(AnalysisModeUserDialogViewModel));
        
        WeakReferenceMessenger.Default.Register<ConfirmDatabaseUserMessage>(this, ConfirmDatabaseUserHandler);
        WeakReferenceMessenger.Default.Register<AnalysisModeUserDialogCloseMessage>(this, OnClose);
        
        InitializeComponent();
    }

    private void OnClose(object? recipient, AnalysisModeUserDialogCloseMessage message)
    {
        Close();
    }

    private void ConfirmDatabaseUserHandler(object? sender, ConfirmDatabaseUserMessage message)
    {
        var viewModel = DataContext as AnalysisModeUserDialogViewModel;
        Close(viewModel!.SelectedUser?.UserId);
    }
    
    private async void Visual_OnAttachedToVisualTree(object? sender, VisualTreeAttachmentEventArgs e)
    {
        await ((AnalysisModeUserDialogViewModel?)DataContext)!.UpdateDatabaseUsersAsync();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private static void Close(object? result = null)
    {
        try
        {
            DialogHost.DialogHost.Close(DialogIdentifier, result);
        }
        //DialogHost.Avalonia doesn't seem to discard the closed sessions correctly and
        //throws exceptions on subsequent dialog openings
        //TODO handle this in some way other than swallowing it
        catch(InvalidOperationException ex) { }
        catch (Exception ex)
        {
            Console.WriteLine($"Dialog closing error: {ex.Message}");
        }
    }
}