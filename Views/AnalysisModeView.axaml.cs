using Avalonia.Controls;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using esquire.ViewModels;

namespace esquire.Views
{
    public partial class AnalysisModeView : UserControl
    {
        public AnalysisModeView()
        {
            InitializeComponent();
        }

        private void InputElement_OnDoubleTapped(object? sender, RoutedEventArgs e)
        { 
            WeakReferenceMessenger.Default.Send(new DataQueryMessage((sender as TreeViewItem)?.Header.ToString() ?? ""));
        }
    }
}
