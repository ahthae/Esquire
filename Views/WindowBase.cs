using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public class WindowBase<T> : Window where T : ViewModelBase
{
    public WindowBase()
    {
        DataContext = App.Current.Services.GetService(typeof(T));
        WeakReferenceMessenger.Default.Register<OpenDialogMessage<T>>(this, OpenDialog);
    }
    
    public void OpenDialog(object? recipient, OpenDialogMessage<T> message)
    {
        Show();
        Type viewModelType = message.GetType().GenericTypeArguments[0];

//        var dialogWindow = Activator.CreateInstance(viewModelType);
//        dialogWindow.ShowDialog(this);
    }
}