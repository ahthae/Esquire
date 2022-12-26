using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace esquire.ViewModels;

public partial class LogViewModel : ViewModelBase
{
    [ObservableProperty] private List<string> _log = new();
    
    public LogViewModel()
    {
        
    }

    [RelayCommand]
    public void WriteLine(string value)
    {
        Log.Add(value);
    }
}