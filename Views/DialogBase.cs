using esquire.ViewModels;

namespace esquire.Views;

public class DialogBase<T> : WindowBase<T>  where T : ViewModelBase
{
    protected virtual void DialogCloseMessageHandler(object? recipient, DialogCloseMessage message)
    {
        Close();
    }
}