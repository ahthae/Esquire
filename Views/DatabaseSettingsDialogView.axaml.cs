using Avalonia;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public partial class DatabaseSettingsDialogView : DialogBase<DatabaseSettingsDialogViewModel>
{
    public DatabaseSettingsDialogView()
    {
        WeakReferenceMessenger.Default.Register<DatabaseSettingsDialogCloseMessage>(this, DialogCloseMessageHandler);
        
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