using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace esquire.ViewModels;

public class DialogCloseMessage { }
public class DialogCloseRequestMessage<T> : RequestMessage<T>  { }
public class DialogCloseCollectionRequestMessage<T> : CollectionRequestMessage<T>  { }
public class AsyncDialogCloseRequestMessage<T> : AsyncRequestMessage<T> { }
public class AsyncDialogCloseCollectionRequestMessage<T> : AsyncCollectionRequestMessage<T> { }

public abstract class DialogViewModelBase : ViewModelBase
{
    protected abstract void SendCloseMessage();
}