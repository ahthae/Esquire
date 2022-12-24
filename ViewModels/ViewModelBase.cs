using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace esquire.ViewModels;

// T = view model of dialog to open
public class OpenDialogMessage<T> where T : ViewModelBase { }

public class CloseMessage<T> { }
public class CloseRequestMessage<T> : RequestMessage<T>  { }
public class CloseCollectionRequestMessage<T> : CollectionRequestMessage<T>  { }
public class AsyncCloseRequestMessage<T> : AsyncRequestMessage<T> { }
public class AsyncCloseCollectionRequestMessage<T> : AsyncCollectionRequestMessage<T> { }

public abstract class ViewModelBase : ObservableRecipient
{
    protected void Close<T>()
    {
        WeakReferenceMessenger.Default.Send<CloseMessage<T>>();
    }
}
