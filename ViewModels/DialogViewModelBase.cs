using CommunityToolkit.Mvvm.ComponentModel;
using HanumanInstitute.MvvmDialogs;
using System;

namespace esquire.ViewModels;

public abstract partial class DialogViewModelBase : ViewModelBase, IModalDialogViewModel, ICloseable
{
    [ObservableProperty] private bool? _dialogResult;

    public event EventHandler? RequestClose;

    protected void RaiseCloseEvent()
    {
        RequestClose?.Invoke(this, EventArgs.Empty);
    }
}