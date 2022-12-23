using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.Views
{
    public partial class AnalysisModeView : UserControl
    {
        private IServiceProvider _serviceProvider;
        public AnalysisModeView()
        {
            InitializeComponent();
        }

        private void NavigationTreeView_DoubleTap(object? sender, RoutedEventArgs e)
        { 
            SendDataQueryMessage(sender as TreeViewItem);
        }
        private async void NavigationTreeView_DoubleTapWithUser(object? sender, RoutedEventArgs e)
        {
            //TODO find a better way to reference the parent Window
            if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                decimal? userId = await new AnalysisModeUserDialogWindow()
                {
                    DataContext = (DataContext as AnalysisModeViewModel).ServiceProvider.GetService<AnalysisModeUserDialogViewModel>(),
                    Topmost = true
                }.ShowDialog<decimal>(desktop.MainWindow);
                if (userId is not null) SendDataQueryMessage(sender as TreeViewItem, userId);
            }
        }

        private void SendDataQueryMessage(HeaderedItemsControl? sender, decimal? userId = null)
        {
            WeakReferenceMessenger.Default.Send(new DataQueryMessage((sender)?.Header.ToString() ?? "", userId));
        }
    }
}
