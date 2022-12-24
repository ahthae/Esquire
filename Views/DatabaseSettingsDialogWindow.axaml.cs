using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using esquire.ViewModels;
using esquire.Views;

namespace esquire;

public partial class DatabaseSettingsWindow : WindowBase<DatabaseSettingsDialogWindowViewModel>
{
    public DatabaseSettingsWindow()
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
}