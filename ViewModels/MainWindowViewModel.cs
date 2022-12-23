using System;
using CommunityToolkit.Mvvm.Messaging;
using esquire.Services;
using esquire.Services.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class ShowDatabaseSettingsDialogMessage{}

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase page;

    public MainWindowViewModel(IServiceProvider serviceProvider)
    {
        Page = new AnalysisModeViewModel(serviceProvider);
        if (serviceProvider.GetService<ISettingsService>().WasInitialized)
            WeakReferenceMessenger.Default.Send<ShowDatabaseSettingsDialogMessage>();
    }
    
    

    public ViewModelBase Page
    {
        get => page;
        set => SetProperty(ref page, value);
    }
}
