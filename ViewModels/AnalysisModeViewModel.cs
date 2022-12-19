using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Models;
using esquire.Services;

namespace esquire.ViewModels
{
    public class AnalysisModeViewModel : ViewModelBase
    {
        private AnalysisModeDataViewModel dataVm;

        public AnalysisModeViewModel(FusionContext db)
        {
            DataVm = new AnalysisModeDataViewModel();
            
            WeakReferenceMessenger.Default.Register<ValueChangedMessage<string>>(this, (r, m) =>
            {
                var typeString = m.Value;
                DataVm = new AnalysisModeDataViewModel(db);
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
