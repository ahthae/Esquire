using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Services.Settings;
using esquire.ViewModels.AnalysisMode;
using esquire.ViewModels.DatabaseMode;
using HanumanInstitute.MvvmDialogs;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly ILogger<MainWindowViewModel> _logger;
    private readonly IDialogService _dialogService;

    private readonly AnalysisModeViewModel _analysisMode;
    private readonly DatabaseModeViewModel _databaseMode;

    [ObservableProperty] private ViewModelBase _page;
    [ObservableProperty] private ViewModelBase _log;

    public MainWindowViewModel(ILogger<MainWindowViewModel> logger,
        IDialogService dialogService,
        ISettingsService settings,
        LogViewModel logViewModel,
        AnalysisModeViewModel analysisModeViewModel,
        DatabaseModeViewModel databaseModeViewModel)
    {
        _logger = logger;
        _dialogService = dialogService;

        _log = logViewModel;
        _analysisMode = analysisModeViewModel;
        _databaseMode = databaseModeViewModel;
        Page = _analysisMode;

        if (settings.WasInitialized)
            ShowDatabaseSettingsDialogAsync();
    }
    
    [RelayCommand]
    public async void ShowDatabaseSettingsDialogAsync()
    {
        var dbSettingsDialog = _dialogService.CreateViewModel<DatabaseSettingsDialogViewModel>();
        await _dialogService.ShowDialogAsync(this, dbSettingsDialog);
    }
}
