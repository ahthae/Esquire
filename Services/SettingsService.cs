using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace esquire.Services;

public class SettingsService : ObservableObject, ISettingsService
{
    private const string ConfigDirectory = "Config";
    private const string ConfigurationFile = "appsettings.json";
    private ISettingsService.IOptions _settings;
    private IConfiguration _config;

    public SettingsService()
    {
        _config = new ConfigurationBuilder()
            .AddJsonFile(GetConfigPath())
            .Build();
        Settings = _config.Get<Options>();
    }
    
    public class Options : ObservableObject, ISettingsService.IOptions
    {
        private ISettingsService.IOptions.DatabaseProvider _dbProvider;
        
        public ISettingsService.IOptions.DatabaseProvider DbProvider 
        {
            get => _dbProvider;
            set => SetProperty(ref _dbProvider, value);
        }
    }
    
    public ISettingsService.IOptions Settings 
    { 
        get => _settings;
        set => SetProperty(ref _settings, value); 
    }

    private static string GetConfigPath()
    {
        return Path.Join(ConfigDirectory, ConfigurationFile);
    }
}