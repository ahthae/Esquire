using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace esquire.Services.Settings;

public class SettingsService : ObservableObject, ISettingsService
{
    private const string ConfigDirectory = "Config";
    private const string ConfigurationFile = "appsettings.json";
    private Options _settings;

    public SettingsService()
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile(GetConfigPath())
            .Build();
        Settings = config.Get<Options>();
    }
    
    public Options Settings 
    { 
        get => _settings;
        set => SetProperty(ref _settings, value); 
    }

    private static string GetConfigPath()
    {
        return Path.Join(ConfigDirectory, ConfigurationFile);
    }
}