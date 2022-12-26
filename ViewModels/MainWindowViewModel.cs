using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Services.Settings;
using esquire.ViewModels.AnalysisMode;
using esquire.ViewModels.DatabaseMode;

namespace esquire.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly AnalysisModeViewModel _analysisMode;
    private readonly DatabaseModeViewModel _databaseMode;
    [ObservableProperty] private ViewModelBase _page;

    public MainWindowViewModel(ISettingsService settings,
        AnalysisModeViewModel analysisModeViewModel,
        DatabaseModeViewModel databaseModeViewModel)
    {
        _analysisMode = analysisModeViewModel;
        _databaseMode = databaseModeViewModel;
        Page = _analysisMode;

        if (settings.WasInitialized)
            ShowDatabaseSettingsDialog();
    }
    
    [RelayCommand]
    public void ShowDatabaseSettingsDialog() => OpenDialog<DatabaseSettingsDialogViewModel>();
}
