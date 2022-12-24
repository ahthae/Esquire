using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using esquire.ViewModels;
using esquire.Views;

namespace esquire.Views;

public partial class DatabaseSettingsDialogView : DialogBase<DatabaseSettingsDialogViewModel>
{
    public DatabaseSettingsDialogView()
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