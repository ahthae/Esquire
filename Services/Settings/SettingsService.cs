using System;
using System.IO;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace esquire.Services.Settings;

public class SettingsService : ObservableObject, ISettingsService
{
    private const string ConfigDirectory = "Config";
    private const string ConfigurationFile = "appsettings.json";
    private Options _settings = new();
    private bool _wasInitialized = false;

    public SettingsService()
    {
        CheckAndCreateConfigPath();
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile(GetConfigPath(), false, true)
            .Build();
        Settings = config.Get<Options>();
    }

    public bool WasInitialized
    {
        get => _wasInitialized;
        set => SetProperty(ref _wasInitialized, value);
    }
    
    public Options Settings 
    { 
        get => _settings;
        set => SetProperty(ref _settings, value); 
    }

    public void Write()
    {
        CheckAndCreateConfigPath();
        File.WriteAllText(GetConfigPath(), JsonSerializer.Serialize(Settings));
    }

    // Checks whether the config file path exists and creates it if it doesn't
    private void CheckAndCreateConfigPath()
    {
        string configPath = GetConfigPath();
        if (!(new DirectoryInfo(ConfigDirectory).Exists))
        {
            Console.WriteLine($"Creating new Config directory at {Path.GetFullPath(configPath)}");
            Directory.CreateDirectory(ConfigDirectory);
        }
        if (!(new FileInfo(configPath).Exists))
        {
            Console.WriteLine($"Creating new config file at {Path.GetFullPath(configPath)}");
            Write();
            WasInitialized = true;
        }
    }
    
    private static string GetConfigPath()
    {
        return Path.Join(ConfigDirectory, ConfigurationFile);
    }
}