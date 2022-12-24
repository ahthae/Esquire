using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace esquire.ViewModels;

public class CloseMessage<T> { }
public class CloseRequestMessage<T> : RequestMessage<T>  { }
public class CloseCollectionRequestMessage<T> : CollectionRequestMessage<T>  { }
public class AsyncCloseRequestMessage<T> : AsyncRequestMessage<T> { }
public class AsyncCloseCollectionRequestMessage<T> : AsyncCollectionRequestMessage<T> { }

public class DialogViewModelBase : ViewModelBase
{
    protected void Close<T>()
    {
        WeakReferenceMessenger.Default.Send<CloseMessage<T>>();
    }
}