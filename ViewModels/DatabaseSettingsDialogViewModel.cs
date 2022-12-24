using System;
using System.Data.Common;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Services;
using esquire.Services.Settings;
using Options = esquire.Services.Settings.Options;

namespace esquire.ViewModels;

public partial class DatabaseSettingsDialogViewModel : DialogViewModelBase
{
    private readonly ISettingsService _settingsService;
    private readonly IDatabaseService _databaseService;
    [ObservableProperty] private Options _settings;
    [ObservableProperty] private string _connectionTestResult;

    public DatabaseSettingsDialogViewModel(ISettingsService settingsService, IDatabaseService databaseService)
    {
        _databaseService = databaseService;
        _settingsService = settingsService;
        _settings = settingsService.Settings;
    }

    [RelayCommand]
    public void Confirm()
    {
        SaveSettings();
        Close<DatabaseSettingsDialogViewModel>();
    }
    [RelayCommand]
    public void Cancel()
    {
        Close<DatabaseSettingsDialogViewModel>();
    }
    [RelayCommand]
    public async Task<bool> TestConnection()
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
        DbConnection connection = _databaseService.GetConnection();
        connection.Open();
        connection.Close();
        ConnectionTestResult = "Connection test successful!";
        Console.WriteLine(ConnectionTestResult);
    }
    
    private void SaveSettings()
    {
        _settingsService.Settings = Settings;
        _settingsService.Write();
    }
}