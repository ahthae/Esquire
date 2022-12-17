using esquire.Services;

namespace esquire.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase data;

    public MainWindowViewModel()
    {
        this.Data = new AnalysisModeViewModel(new OralceService());
    }

    public ViewModelBase Data 
    {
        get => data;
        set => SetProperty(ref data, value);
    }
}
