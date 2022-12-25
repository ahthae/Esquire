using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Threading;
using esquire.ViewModels;

namespace esquire.Views
{
    public partial class AnalysisModeView : UserControl
    {
        private readonly string _dialogIdentifier = "QueryDialog";
        
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
            var dialogVm = (AnalysisModeUserDialogViewModel?)App.Current!.Services.GetService(typeof(AnalysisModeUserDialogViewModel));
            if (dialogVm is null) Console.WriteLine("Error retrieving data: unable to create dialog");
            {
                decimal? userId = (decimal?)await DialogHost.DialogHost.Show(dialogVm!, _dialogIdentifier);
                if (userId is not null) SendDataQueryMessage(sender as TreeViewItem, userId);
            }
        }

        private async void SendDataQueryMessage(HeaderedItemsControl? sender, decimal? userId = null) //TODO more generic way of passing query parameters
        {
            AnalysisModeViewModel dataContext = (AnalysisModeViewModel?)DataContext;
            string queryType = sender.Header as string;
            await Task.Run(async () => await dataContext.RunQueryAsync(queryType as string, userId));
        }
    }
}
