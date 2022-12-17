using esquire.Services;

namespace esquire.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase page;

    public MainWindowViewModel()
    {
        this.Page = new AnalysisModeViewModel(new OralceService());
    }

    public ViewModelBase Page
    {
        get => page;
        set => SetProperty(ref page, value);
    }
}
