using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace esquire.Services;

public class SettingsService : ObservableObject, ISettingsService
{
    private const string ConfigDirectory = "Config";
    private const string ConfigurationFile = "appsettings.json";
    private ISettingsService.AppSettings _settings;
    private IConfiguration _config;

    public SettingsService()
    {
        _config = new ConfigurationBuilder()
            .AddJsonFile(GetConfigPath())
            .Build();
        Settings = _config.Get<ISettingsService.AppSettings>();
    }
    
    public ISettingsService.AppSettings Settings 
    { 
        get => _settings;
        set => SetProperty(ref _settings, value); 
    }

    private static string GetConfigPath()
    {
        return Path.Join(ConfigDirectory, ConfigurationFile);
    }
}