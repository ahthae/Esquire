using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Configuration;

namespace esquire.Services.Settings;

public interface ISettingsService
{
    public Options Settings { get; set; }
    public IConfiguration Config { get; set; }
    public bool WasInitialized { get; set; }
    public string GetConfigPath();
    public string GetLogConfigPath();
    public void Write();
}

public partial class Options : ObservableObject
{
    [ObservableProperty] private DatabaseOptions _database = new();
    [ObservableProperty] private LoggingOptions _logging = new();
    
    public partial class DatabaseOptions : ObservableObject
    {
        [ObservableProperty] private ProviderType _provider = ProviderType.Oracle;
        [ObservableProperty] private string _userId = "SYSTEM";
        [ObservableProperty] private string _password = "";
        [ObservableProperty] private string _dataSource  = "XEPDB1";
        
        public enum ProviderType
        {
            Oracle
        }
    }

    public partial class LoggingOptions : ObservableObject
    {
        [ObservableProperty] private LogLevelOptions _logLevel = new();

        public partial class LogLevelOptions : ObservableObject
        {
            [ObservableProperty] private string _default = "Debug";
            [ObservableProperty] private string _system = "Information";
            [ObservableProperty] private string _microsoft = "Information";
        }
    }
}