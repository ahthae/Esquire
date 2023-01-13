using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace esquire.ViewModels;

public abstract class ViewModelBase : ObservableRecipient
{
    protected static void SendLogMessage(string message)
    {
        WeakReferenceMessenger.Default.Send(new LogMessage(message));
    }
}
