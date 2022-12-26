using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using esquire.Services.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels;

public partial class LogViewModel : ViewModelBase
{
    private ILogger<LogViewModel> _logger;
    private string? _logFilePath;
    [ObservableProperty] private Task<string?> _log;

    public LogViewModel(ILogger<LogViewModel> logger, ISettingsService settings)
    {
        _logger = logger;
        
        _logFilePath = Path.GetFullPath(settings.Config.GetValue<string>("Serilog:WriteTo:Async:Args:configure:0:Args:path"));
        string? directory = Path.GetDirectoryName(_logFilePath);
        
        if (directory is not null && !Directory.Exists(_logFilePath))
        {
            Directory.CreateDirectory(directory);
        }
        if (_logFilePath is null && !File.Exists(_logFilePath))
        {
            _logger.LogError("Could not retrieve log file");
            return;
        }

        _log = ReadFileAsync(_logFilePath);

        using var watcher = new FileSystemWatcher(directory!);
//        watcher.NotifyFilter = NotifyFilters.LastWrite;
        watcher.EnableRaisingEvents = true;
        watcher.Changed += ReadLogFile;
//        watcher.Filter = Path.GetFileName(_logFilePath);
    }

    private void ReadLogFile(object sender, FileSystemEventArgs e) //TODO
    {
        _logger.LogInformation("Reading from log file");
        _log = ReadFileAsync(e.FullPath);
    }

    private static async Task<string?> ReadFileAsync(string path)
    {
        
        await using FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
        using StreamReader reader = new StreamReader(stream);

        return await reader.ReadLineAsync();
    }
}