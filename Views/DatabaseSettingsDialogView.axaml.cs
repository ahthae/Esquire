using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace esquire.Views;

public partial class DatabaseSettingsDialogView : Window
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