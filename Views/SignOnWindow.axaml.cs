using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace esquire;

public partial class SignOnWindow : Window
{
    public SignOnWindow()
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