using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using esquire.Services.Settings;
using esquire.ViewModels;
using esquire.Views;
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

        return services.BuildServiceProvider();
    }
}