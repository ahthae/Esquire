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
using esquire.ViewModels.AnalysisMode;
using esquire.ViewModels.DatabaseMode;
using esquire.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;

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

    public IServiceProvider Services { get; private set; }

    private void ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddTransient<MainWindowViewModel>();
        services.AddTransient<LogViewModel>();
        services.AddTransient<DatabaseSettingsDialogViewModel>();
        services.AddTransient<DatabaseModeViewModel>();
        services.AddTransient<AnalysisModeViewModel>();
        services.AddTransient<UserDialogViewModel>();

        services.AddSingleton<ISettingsService, SettingsService>();
        services.AddSingleton<CsvExportService>();
        services.AddSingleton<ILoggerFactory>(provider =>
        {
            ISettingsService settings = provider.GetService<ISettingsService>();
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(settings.GetConfigPath())
                .Build();
            Logger logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
            return new LoggerFactory().AddSerilog(logger);
        });
        services.AddLogging();
        
        services.AddScoped<IDatabaseService, DatabaseService>();
        services.AddDbContextPool<FusionContext>(options =>
        {
            IDatabaseService? db = Current.Services.GetService<IDatabaseService>();
            DbConnection connection = db.GetConnection();
            Console.WriteLine(connection.ConnectionString);
            options.UseModel(Models.Compiled.FusionContextModel.Instance);
            options.UseOracle(connection);
        });

        Services = services.BuildServiceProvider();
    }
}