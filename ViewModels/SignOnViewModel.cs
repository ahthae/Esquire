using esquire.Services.Settings;

namespace esquire.ViewModels;

public class SignOnViewModel : ViewModelBase
{
    private ISettingsService _settingsService;
    private Options _settings;
    
    public SignOnViewModel(ISettingsService settingsService)
    {
        _settingsService = settingsService;
        _settings = settingsService.Settings;
    }

    public Options Settings
    {
        get => _settings;
        set => SetProperty(ref _settings, value);
    }

    public void ConfirmButton_OnClick()
    {
        _settingsService.Settings = Settings;
        _settingsService.Write();
    }
}