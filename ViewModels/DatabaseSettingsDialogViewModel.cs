using System;
using System.Data.Common;
using System.Text.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Services;
using esquire.Services.Settings;
using Microsoft.Extensions.Logging;
using Options = esquire.Services.Settings.Options;

namespace esquire.ViewModels;

public partial class DatabaseSettingsDialogViewModel : DialogViewModelBase
{
    private readonly ILogger<DatabaseSettingsDialogViewModel> _logger;
    private readonly ISettingsService _settingsService;
    private readonly IDatabaseService _databaseService;
    [ObservableProperty] private Options _settings;
    [ObservableProperty] private string _connectionTestResult = "";

    public DatabaseSettingsDialogViewModel(ILogger<DatabaseSettingsDialogViewModel> logger,
        ISettingsService settingsService,
        IDatabaseService databaseService)
    {
        _logger = logger;
        _databaseService = databaseService;
        _settingsService = settingsService;
        _settings = JsonSerializer.Deserialize<Options>(JsonSerializer.Serialize(_settingsService.Settings));
    }

    [RelayCommand]
    public void OnConfirm()
    {
        SaveSettings();
        RaiseCloseEvent();
    }

    [RelayCommand]
    public void OnCancel()
    {
        RaiseCloseEvent();
    }

    [RelayCommand]
    public async Task<bool> OnTestConnection()
    {
        try
        {
            await Task.Run(TestDatabaseConnection);
            return true;
        }
        catch (Exception ex)
        {
            ConnectionTestResult = $"Connection test failed:\n{ex.Message}";
            Console.WriteLine(ConnectionTestResult);
            return false;
        }
    }

    private void TestDatabaseConnection()
    {
        using DbConnection connection = _databaseService.GetConnection(_settings);
        connection.Open();
        connection.Close();
        ConnectionTestResult = "Connection test successful!";
        _logger.LogInformation(ConnectionTestResult);
    }
    
    private void SaveSettings()
    {
        _settingsService.Settings = Settings;
        _settingsService.Write();
        _logger.LogInformation("Settings saved.");
    }
}