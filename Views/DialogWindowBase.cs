using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public class DialogWindowBase<T> : Window where T : ViewModelBase
{
    public DialogWindowBase()
    {
        WeakReferenceMessenger.Default.Register<CloseMessage<T>>(this, (recipient, message) => Close());
    }
}