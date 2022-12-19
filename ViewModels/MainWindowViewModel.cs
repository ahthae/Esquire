using System;
using esquire.Services;
using esquire.Services.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase page;

    public MainWindowViewModel(IServiceProvider services)
    {
        this.Page = new AnalysisModeViewModel(new OralceService(services.GetService<ISettingsService>()));
    }

    public ViewModelBase Page
    {
        get => page;
        set => SetProperty(ref page, value);
    }
}
