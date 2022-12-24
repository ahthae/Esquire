using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public abstract class DialogBase<T> : Window where T : ViewModelBase
{
    public DialogBase()
    {
        DataContext = App.Current.Services.GetService(typeof(T));
        WeakReferenceMessenger.Default.Register<CloseMessage<T>>(this, CloseHandler);
    }

    private void CloseHandler(object? recipient, CloseMessage<T> message)
    {
        Close();
    }
}