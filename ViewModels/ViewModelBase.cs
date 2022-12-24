using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace esquire.ViewModels;

public class OpenDialogMessage
{
    public Type ViewModelType { get; set; }
    public OpenDialogMessage(Type viewModelType) => ViewModelType= viewModelType;
}
// T = view model of dialog to open
// R = return type of dialog
public class OpenDialogMessage<T, R> where T : ViewModelBase { }

public abstract class ViewModelBase : ObservableRecipient
{
    protected void OpenDialog<T>() where T : ViewModelBase
    {
        WeakReferenceMessenger.Default.Send(new OpenDialogMessage(typeof(T)));
    }
}
