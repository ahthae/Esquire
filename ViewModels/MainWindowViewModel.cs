using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using esquire.Services.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class ShowDatabaseSettingsDialogMessage{}

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ViewModelBase _page;

    public MainWindowViewModel()
    {
        Page = new AnalysisModeViewModel();
        if (App.Current!.Services.GetService<ISettingsService>().WasInitialized)
            WeakReferenceMessenger.Default.Send<ShowDatabaseSettingsDialogMessage>();
    }
    
}
