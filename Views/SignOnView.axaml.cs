using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using esquire.ViewModels;

namespace esquire.Views;

public partial class SignOnView : UserControl
{
    public SignOnView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}