using System.Collections.Generic;
using System.Collections.ObjectModel;
using esquire.Models;
using esquire.Services;

namespace esquire.ViewModels
{
    public class AnalysisModeViewModel : ViewModelBase
    {
        private DatabaseService db;
        private ObservableCollection<BusinessUnit> businessUnits;

        public AnalysisModeViewModel(DatabaseService db)
        {
            this.db = db;
            QueryBusinessUnits();
        }

        private void QueryBusinessUnits()
        {
            var list = new List<BusinessUnit>();
            db.Query(list);
            BusinessUnits = new ObservableCollection<BusinessUnit>(list);
        }

        public ObservableCollection<BusinessUnit> BusinessUnits
        {
            get => businessUnits;
            set => SetProperty(ref businessUnits, value);
        }
    }
}
