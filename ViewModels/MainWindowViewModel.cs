using System;
using esquire.Data.Fusion;
using esquire.Services;
using esquire.Services.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase page;

    public MainWindowViewModel(IServiceProvider services)
    {
        this.Page = new AnalysisModeViewModel(services.GetService<FusionContext>());
    }

    public ViewModelBase Page
    {
        get => page;
        set => SetProperty(ref page, value);
    }
}
