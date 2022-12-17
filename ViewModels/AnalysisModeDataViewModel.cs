using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using esquire.Models;
using esquire.Services;

namespace esquire.ViewModels;

public class AnalysisModeDataViewModel : ViewModelBase
{
    private ObservableCollection<BusinessUnit> data;

    public AnalysisModeDataViewModel()
    {
        data = new ObservableCollection<BusinessUnit>();
    }
    public AnalysisModeDataViewModel(IDatabaseService db)
    {
        var list = new List<BusinessUnit>();
        db.Query(list);
        Data = new ObservableCollection<BusinessUnit>(list);
    }

    public ObservableCollection<BusinessUnit> Data
    {
        get => data;
        set => SetProperty(ref data, value);
    }
}