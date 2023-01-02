using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using esquire.ViewModels.AnalysisMode;

namespace esquire.Views.AnalysisMode;

public partial class UserDialogView : Window
{
    public UserDialogView()
    {
        InitializeComponent();
    }
    
    private async void OnOpened(object? sender, EventArgs e)
    {
        await ((UserDialogViewModel?)DataContext).UpdateDatabaseUsersAsync();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}