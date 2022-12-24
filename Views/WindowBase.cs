using Avalonia.Controls;
using esquire.ViewModels;

namespace esquire.Views;

public abstract class WindowBase<T> : Window where T : ViewModelBase
{
    protected WindowBase()
    {
        DataContext = App.Current!.Services.GetService(typeof(T));
    }
}