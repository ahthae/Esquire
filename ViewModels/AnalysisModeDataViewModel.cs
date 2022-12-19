using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using esquire.Data.Fusion;
using esquire.Models;
using esquire.Models.Fusion;
using Microsoft.EntityFrameworkCore;

namespace esquire.ViewModels;

public class AnalysisModeDataViewModel : ViewModelBase
{
    private ObservableCollection<FunAllBusinessUnitsV> data;

    public AnalysisModeDataViewModel()
    {
        data = new ObservableCollection<FunAllBusinessUnitsV>();
    }
    public AnalysisModeDataViewModel(FusionContext db)
    {
        DbContext context = new FusionContext();
        data = new ObservableCollection<FunAllBusinessUnitsV>(db.FunAllBusinessUnitsVs.ToArray());
    }

    public ObservableCollection<FunAllBusinessUnitsV> Data
    {
        get => data;
        set => SetProperty(ref data, value);
    }
}