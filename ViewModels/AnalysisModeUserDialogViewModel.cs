using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using esquire.Data.Fusion;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class GetDatabaseUsersMessage { }

public partial class AnalysisModeUserDialogViewModel : ViewModelBase
{
    public class UserDialogUser
    {
        public string? Username { get; set; }
        public string? UserGuid { get; set; }
        public decimal? UserId { get; set; }
    }
    
    private readonly IServiceProvider _serviceProvider;
    [ObservableProperty] private ObservableCollection<UserDialogUser> _users;
    [ObservableProperty] private UserDialogUser _selectedUser;

    public AnalysisModeUserDialogViewModel(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        WeakReferenceMessenger.Default.Register<AnalysisModeUserDialogViewModel, GetDatabaseUsersMessage>(this, (r, m) => { GetDatabaseUsersAsync(); });

//        GetDatabaseUsers = new AsyncRelayCommand(PopulateUsers);
    }

    public IAsyncRelayCommand GetDatabaseUsers { get; }

    private async Task<IEnumerable> PopulateUsers(string text, CancellationToken token)
    {
        return from user in await GetDatabaseUsersAsync()
            select new { user.Username };
    }

    private async Task<ObservableCollection<UserDialogUser>> GetDatabaseUsersAsync()
    {
        try
        {
            await Task.Run(() =>
            {
                FusionContext? db = _serviceProvider.GetService<FusionContext>();
                Users = new ObservableCollection<UserDialogUser>(
                    from user in db!.PerUsers.Where(user => user.ActiveFlag == "Y")
                    select new UserDialogUser()
                    {
                        Username = user.Username,
                        UserGuid = user.UserGuid,
                        UserId = user.UserId
                    });
            });
            return Users;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error querying database for users {ex.Message}");
            return null;
        }
    }
}