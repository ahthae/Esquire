using System;
using System.Data.Common;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using esquire.Data.Fusion;
using esquire.Services;
using esquire.Services.Export;
using esquire.Services.Settings;
using esquire.ViewModels;
using esquire.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
    
    public static App? Current => (App?)Application.Current;
    
    public IServiceProvider Services { get; private set; }

    public void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<DatabaseSettingsDialogWindowViewModel>();
        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<DatabaseModeViewModel>();
        services.AddTransient<AnalysisModeViewModel>();
        services.AddTransient<AnalysisModeUserDialogViewModel>();

        services.AddSingleton<ISettingsService, SettingsService>();
        services.AddSingleton<CsvExportService>();
        
        services.AddScoped<IDatabaseService, DatabaseService>();
        services.AddDbContext<FusionContext>((serviceProvider, options) => {
            IDatabaseService db = serviceProvider.GetService<IDatabaseService>();
            DbConnection connection = db.GetConnection();
            Console.WriteLine(connection.ConnectionString);
            options.UseOracle(connection);
        }, ServiceLifetime.Transient);

        Services = services.BuildServiceProvider();
    }
}