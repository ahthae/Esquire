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
            switch (query)
            {
                case "BusinessUnits":
                    await dataContext.QueryBusinessUnitsAsync();
                    break;
                case "BusinessUnitOrganizations":
                    await dataContext.QueryBusinessUnitOrganizationsAsync();
                    break;
                
                case "PrimaryBusinessUnits":
                    await dataContext.QueryPrimaryBusinessUnitsAsync();
                    break;
                case "PrimaryBusinessUnitsForUser":
                {
                    await dataContext.QueryPrimaryBusinessUnitsForUserAsync();
                    break;
                }
                
                case "AllBusinessUnits":
                    await dataContext.QueryAllBusinessUnitsAsync();
                    break;
                case "AllBusinessUnitsForUser":
                {
                    await dataContext.QueryAllBusinessUnitsForUserAsync();
                    break;
                }

                case "BusinessUnitSecurityAse":
                    break;
                case "BusinessUnitSecurityAseForRoleCode":
                    break;
                case "BusinessUnitSecurityAseForRoleName":
                    break;
                
                case "BusinessUnitDataSecurity":
                        await dataContext.QueryBusinessUnitDataSecurityAsync();
                        break;
                case "BusinessUnitDataSecurityForUser":
                    await dataContext.QueryBusinessUnitDataSecurityForUserAsync();
                    break;
                
                default:
                    _logger.LogWarning("Query for {query} not found", query);
                    break;
            }
        }
    }
}
