using System;
using System.Data.Common;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Services;
using esquire.Services.Settings;
using Options = esquire.Services.Settings.Options;

namespace esquire.ViewModels;

public partial class DatabaseSettingsDialogWindowViewModel : ViewModelBase
{
    private readonly ISettingsService _settingsService;
    private readonly IDatabaseService _databaseService;
    [ObservableProperty] private Options _settings;
    [ObservableProperty] private string _connectionTestResult;

    public DatabaseSettingsDialogWindowViewModel(ISettingsService settingsService, IDatabaseService databaseService)
    {
        _databaseService = databaseService;
        _settingsService = settingsService;
        _settings = settingsService.Settings;
    }

    [RelayCommand]
    public void Confirm()
    {
        SaveSettings();
        Close<DatabaseSettingsDialogWindowViewModel>();
    }
    [RelayCommand]
    public void Cancel()
    {
        Close<DatabaseSettingsDialogWindowViewModel>();
    }

    public async Task<bool> TestConnection()
    {
        try
        {
            return await Task.Run(() =>
            {
                DbConnection connection = _databaseService.GetConnection();
                connection.Open();
                connection.Close();
                ConnectionTestResult = "Connection test successful!";
                Console.WriteLine(ConnectionTestResult);
                return true;
            });
        }
        catch (Exception ex)
        {
            ConnectionTestResult = $"Connection test failed:\n{ex.Message}";
            Console.WriteLine(ConnectionTestResult);
            return false;
        }
    }
    
    private void SaveSettings()
    {
        _settingsService.Settings = Settings;
        _settingsService.Write();
    }
}