using System.Data.Common;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.DependencyInjection;
using esquire.Data.Fusion;
using esquire.Services;
using esquire.Services.Export;
using esquire.Services.Repositories;
using esquire.Services.Settings;
using esquire.ViewModels;
using esquire.ViewModels.AnalysisMode;
using esquire.ViewModels.DatabaseMode;
using esquire.Views;
using HanumanInstitute.MvvmDialogs;
using HanumanInstitute.MvvmDialogs.Avalonia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace esquire;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        ConfigureServices();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }
    
    public new static App? Current => (App?)Application.Current;

    private void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<LogViewModel>();
        services.AddTransient<DatabaseSettingsDialogViewModel>();
        services.AddTransient<DatabaseModeViewModel>();
        services.AddTransient<AnalysisModeViewModel>();
        services.AddTransient<UserDialogViewModel>();

        services.AddSingleton<IDialogService>(new DialogService(
            new DialogManager(viewLocator: new ViewLocator()),
            viewModelFactory: x => App.Current!.Services.GetService(x)));

        services.AddSingleton<ISettingsService, SettingsService>();
        services.AddSingleton<CsvExportService>();
        services.AddSingleton<ILoggerFactory>(provider =>
        {
            ISettingsService settings = provider.GetRequiredService<ISettingsService>();
            Logger logger = new LoggerConfiguration()
                .ReadFrom.Configuration(settings.Config)
                .CreateLogger();
            return new LoggerFactory().AddSerilog(logger);
        });
        services.AddLogging();

        services.AddSingleton<IBusinessUnitsRepository, BusinessUnitsRepository>();
        
        services.AddScoped<IDatabaseService, DatabaseService>();
        services.AddDbContextFactory<BusinessUnitsContext>();

        Ioc.Default.ConfigureServices(services.BuildServiceProvider());
    }
}