using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Services.Settings;
using esquire.ViewModels.AnalysisMode;
using esquire.ViewModels.DatabaseMode;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly ILogger _logger;
    private readonly AnalysisModeViewModel _analysisMode;
    private readonly DatabaseModeViewModel _databaseMode;
    [ObservableProperty] private ViewModelBase _page;
    [ObservableProperty] private ViewModelBase _log;

    public MainWindowViewModel(ILogger<MainWindowViewModel> logger,
        ISettingsService settings,
        LogViewModel logViewModel,
        AnalysisModeViewModel analysisModeViewModel,
        DatabaseModeViewModel databaseModeViewModel)
    {
        _logger = logger;

        _log = logViewModel;
        _analysisMode = analysisModeViewModel;
        _databaseMode = databaseModeViewModel;
        Page = _analysisMode;

        if (settings.WasInitialized)
            ShowDatabaseSettingsDialog();
    }
    
    [RelayCommand]
    public void ShowDatabaseSettingsDialog() => OpenDialog<DatabaseSettingsDialogViewModel>();
}
