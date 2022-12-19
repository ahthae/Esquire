using System;
using System.Collections;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Data.Fusion;
using esquire.Models.Fusion;
using Microsoft.EntityFrameworkCore;

namespace esquire.ViewModels
{
    public partial class AnalysisModeViewModel : ViewModelBase
    {
        [ObservableProperty] private IEnumerable _data;
        [ObservableProperty] private ObservableCollection<FunAllBusinessUnitsV> _businessUnits;
        
        public AnalysisModeViewModel(FusionContext db)
        {
            WeakReferenceMessenger.Default.Register<ValueChangedMessage<string>>(this, async (r, m) => 
            {
                try
                {
                    switch (m.Value)
                    {
                        case "Business Units": Data = new ObservableCollection<FunAllBusinessUnitsV>(await db.FunAllBusinessUnitsVs.ToListAsync()); break;
                        case "Business Unit Organizations": Data = new ObservableCollection<FunAllBusinessUnitsV>(await db.FunAllBusinessUnitsVs.ToListAsync()); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
        }
    }
    
}
