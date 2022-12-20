using System;
using CommunityToolkit.Mvvm.Messaging;
using esquire.Data.Fusion;
using esquire.Services.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class SignOnShowMessage{}

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase page;

    public MainWindowViewModel(FusionContext dbContext)
    {
        this.Page = new AnalysisModeViewModel(dbContext);
//        if (services.GetService<ISettingsService>().WasInitialized)
        if (true)
            WeakReferenceMessenger.Default.Send<SignOnShowMessage>();
    }
    
    

    public ViewModelBase Page
    {
        get => page;
        set => SetProperty(ref page, value);
    }
}
