using CommunityToolkit.Mvvm.ComponentModel;

namespace esquire.Services.Settings;

public interface ISettingsService
{
    public Options Settings { get; set; }
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
