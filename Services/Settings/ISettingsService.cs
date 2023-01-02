using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;

namespace esquire.Services.Settings;

public interface ISettingsService : INotifyPropertyChanged, INotifyPropertyChanging
{
    public Options Settings { get; set; }
    public IConfiguration Config { get; set; }
    public bool WasInitialized { get; set; }
    public string GetConfigPath();
    public string GetLogConfigPath();
    public void Write();
}

public record Options
{
    public DatabaseOptions Database { get; set; } = new();
    public LoggingOptions Logging { get; set; } = new();
}

public record DatabaseOptions
{
    
    [JsonConverter(typeof(JsonStringEnumConverter))] 
    public ProviderType Provider { get; set; }

    public string UserId { get; set; } = "";
    public string Password { get; set; } = "";
    public string DataSource { get; set; } = "";
    
    public enum ProviderType
    {
        [EnumMember(Value="Oracle")]
        Oracle
    }
}

public record LoggingOptions()
{
    public LogLevelOptions LogLevel { get; set; }
    
    public record LogLevelOptions
    {
        public string Default { get; set; } = "";
        public string System { get; set; } = "";
        public string Microsoft { get; set; } = "";
    }
}
