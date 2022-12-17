using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Models;
using esquire.Services;

namespace esquire.ViewModels
{
    public class AnalysisModeViewModel : ViewModelBase
    {
        private IDatabaseService db;
        private AnalysisModeDataViewModel dataVm;

        public AnalysisModeViewModel(IDatabaseService db)
        {
            this.db = db;
            DataVm = new AnalysisModeDataViewModel();
            
            WeakReferenceMessenger.Default.Register<ValueChangedMessage<string>>(this, (r, m) =>
            {
                var typeString = m.Value;
                DataVm = new AnalysisModeDataViewModel(db);
//            DataVm = (AnalysisModeDataViewModel<BusinessUnit>?) Activator.CreateInstance(typeof(AnalysisModeDataViewModel<>).MakeGenericType(NavigationTypeMap(typeString)), db);
            });
        }

        public AnalysisModeDataViewModel DataVm
        {
            get => dataVm;
            set => SetProperty(ref dataVm, value);
        }

        private static Type NavigationTypeMap(string type)
        {
            switch (type)
            {
                case "Business Units": return typeof(BusinessUnit);
                default: return typeof(Object);
            }
        }
    }
    
}
