using System;
using System.Data.Common;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using esquire.Data.Fusion;
using esquire.Services;
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
        var services = ConfigureServices();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(services),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    public IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddSingleton<ISettingsService, SettingsService>();
        services.AddScoped<IDatabaseService, DatabaseService>();
        services.AddDbContext<FusionContext>((serviceProvider, options) => {
            Options settings = serviceProvider.GetService<ISettingsService>().Settings;
            IDatabaseService db = serviceProvider.GetService<IDatabaseService>();
            DbConnection connection = db.GetConnection();
            Console.WriteLine(connection.ConnectionString);
            options.UseOracle(connection);
        });

    return services.BuildServiceProvider();
    }
}