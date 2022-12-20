using System;
using System.Data.Common;
using esquire.Services;
using esquire.Services.Settings;

namespace esquire.ViewModels;

public class SignOnViewModel : ViewModelBase
{
    private readonly ISettingsService _settingsService;
    private readonly IDatabaseService _databaseService;
    private Options _settings;
    private string _connectionTestResult;

    public SignOnViewModel(ISettingsService settingsService, IDatabaseService databaseService)
    {
        _databaseService = databaseService;
        _settingsService = settingsService;
        _settings = settingsService.Settings;
    }

    public Options Settings
    {
        get => _settings;
        set => SetProperty(ref _settings, value);
    }

    public string ConnectionTestResult
    {
        get => _connectionTestResult;
        set => SetProperty(ref _connectionTestResult, value);
    }

    public bool TestConnection()
    {
        try
        {
            DbConnection connection = _databaseService.GetConnection();
            connection.Open();
            connection.Close();
            ConnectionTestResult = "Connection test successful!";
            Console.WriteLine(ConnectionTestResult);
            return true;
        }
        catch (Exception ex)
        {
            ConnectionTestResult = $"Connection test failed:\n{ex.Message}";
            Console.WriteLine(ConnectionTestResult);
            return false;
        }
    }
    
    public void SaveSettings()
    {
        _settingsService.Settings = Settings;
        _settingsService.Write();
    }
}