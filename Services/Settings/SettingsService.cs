using System;
using System.IO;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace esquire.Services.Settings;

public partial class SettingsService : ObservableObject, ISettingsService
{
    private const string ConfigDirectory = "Config";
    private const string ConfigurationFile = "appsettings.json";
    private const string LogConfigurationFile = "logsettings.json";
    
    [ObservableProperty] private Options _settings = new();
    [ObservableProperty] private IConfiguration _config;
    [ObservableProperty] private bool _wasInitialized = false;

    public SettingsService()
    {
        CreateDirectory(GetConfigPath());
        CreateDirectory(GetLogConfigPath());
        
        if (!CheckFile(GetConfigPath()))
        {
            Console.WriteLine($"Creating new config file at {Path.GetFullPath(GetLogConfigPath())}"); 
            WriteOptions(Settings);
            WasInitialized = true;
        }
        if (!CheckFile(GetLogConfigPath()))
        {
            Console.WriteLine($"Creating new logger config file at {Path.GetFullPath(GetLogConfigPath())}"); 
            WriteDefaultLogOptions();
        }
        
        Config = new ConfigurationBuilder()
            .AddJsonFile(GetConfigPath(), false, true)
            .AddJsonFile(GetLogConfigPath(), false, true)
            .Build();
        
        Settings = _config.Get<Options>();
    }

    public void Write()
    {
        CreateDirectory(GetConfigPath());
        WriteOptions(Settings);
    }

    public string GetLogConfigPath()
    {
        return Path.Join(ConfigDirectory, LogConfigurationFile);
    }
    public string GetConfigPath()
    {
        return Path.Join(ConfigDirectory, ConfigurationFile);
    }

    private void WriteOptions(Options settings)
    {
        File.WriteAllText(GetConfigPath(), JsonSerializer.Serialize(settings));
    }
    private void WriteDefaultLogOptions()
    {
        File.WriteAllText(GetLogConfigPath(), DefaultLogSettings);
    }

    private bool CheckFile(string path)
    {
        return new FileInfo(path).Exists;
    }
    
    // Checks whether the config directory exists and creates it if it doesn't
    private void CreateDirectory(string path)
    {
        string? directory = Path.GetDirectoryName(path);
        
        if (new DirectoryInfo(directory).Exists) return;
        
        Console.WriteLine("Creating new directory at {Path}", Path.GetFullPath(path));
    }

    private static readonly string DefaultLogSettings = @"{
      ""Serilog"": {
        ""WriteTo"" : [ ""Console"" ],
        ""WriteTo:Async"": {
          ""Name"": ""Async"",
          ""Args"": {
            ""configure"": [
              {
                ""Name"": ""File"",
                ""Args"": {
                  ""path"": ""Logs/current.log"",
                  ""outputTemplate"": ""{Timestamp:o} [{Level:u3}] ({Application}/{MachineName}/{ThreadId}) {Message}{NewLine}{Exception}""
                }
              }
            ]
          }
        }
      }
    }";
}