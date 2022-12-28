using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.Services.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace esquire.ViewModels;

public class LogMessage
{
    public string Message { get; }
    public LogMessage(string message) => Message = message;
}

public partial class LogViewModel : ViewModelBase
{
    private string _logLine = "";
    [ObservableProperty] private Stack<string> _log = new();

    public LogViewModel()
    {
        WeakReferenceMessenger.Default.Register<LogMessage>(this, (sender, message) =>
        {
            Log.Push(message.Message);
            LogLine = Log.Peek();
        });
    }

    public string LogLine
    {
        get => _logLine;
        private set => SetProperty(ref _logLine, value);
    }
}