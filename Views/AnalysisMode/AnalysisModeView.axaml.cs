using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.DependencyInjection;
using esquire.Data;
using esquire.ViewModels;
using esquire.ViewModels.AnalysisMode;
using Microsoft.Extensions.Logging;

namespace esquire.Views.AnalysisMode
{
    public partial class AnalysisModeView : UserControl
    {
        private ILogger<AnalysisModeView> _logger;
        private readonly string _userDialogIdentifier = "QueryDialog";
        
        public AnalysisModeView()
        {
            _logger = Ioc.Default.GetService<ILogger<AnalysisModeView>>();
            
            InitializeComponent();
        }
        
        private async void NavigationTreeView_DoubleTap(object? sender, RoutedEventArgs e)
        {
            string query = ((TreeViewItem?)sender)?.Name;
            var dataContext = (AnalysisModeViewModel?)DataContext;
            CloseOpenDialog(_userDialogIdentifier);
            switch (query)
            {
                case "BusinessUnits":
                    await dataContext.QueryBusinessUnitsAsync();
                    break;
                case "BusinessUnitOrganizations":
                    await dataContext.QueryBusinessUnitOrganizationsAsync();
                    break;
                case "BusinessUnitDataSecurityForUser":
                    var user = (UserDto?) await ShowDialog(Ioc.Default.GetService<UserDialogViewModel>(), _userDialogIdentifier);
                    if (user is not null) 
                        await dataContext.QueryBusinessUnitDataSecurityForUserAsync(user);
                    break;
                default:
                    _logger.LogWarning("Query for {query} not found", query);
                    break;
            }
        }

        private async Task<object?> ShowDialog(ViewModelBase? vm, string identifier)
        {
            if (vm is null)
            {
                _logger.LogError("Error retrieving data: unable to get dialog content");
                return null;
            }
            CloseOpenDialog(identifier);
            return await DialogHost.DialogHost.Show(vm, identifier);
        }

        private static void CloseOpenDialog(string identifier)
        {
            var dialog = DialogHost.DialogHost.GetDialogSession(identifier);
            if (DialogHost.DialogHost.IsDialogOpen(identifier)) dialog?.Close();
        }
    }
}
