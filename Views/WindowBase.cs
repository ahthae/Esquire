using Avalonia.Controls;
using CommunityToolkit.Mvvm.DependencyInjection;
using esquire.ViewModels;

namespace esquire.Views;

public abstract class WindowBase<T> : Window where T : ViewModelBase
{
    protected WindowBase()
    {
        DataContext = Ioc.Default.GetService(typeof(T));
    }
}