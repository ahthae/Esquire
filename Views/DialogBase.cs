using Avalonia.Controls;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public abstract class DialogBase<T> : WindowBase<T> where T : ViewModelBase
{
    protected DialogBase()
    {
        WeakReferenceMessenger.Default.Register<CloseMessage<T>>(this, CloseHandler);
    }

    private void CloseHandler(object? recipient, CloseMessage<T> message)
    {
        Close();
    }
}