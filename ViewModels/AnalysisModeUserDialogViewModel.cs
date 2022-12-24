using System;
using System.Collections.Generic;
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

public class AnalysisModeUserDialogCloseMessage : DialogCloseMessage {}
public class GetDatabaseUsersMessage { }
public class ConfirmDatabaseUserMessage { }

public partial class AnalysisModeUserDialogViewModel : DialogViewModelBase
{
    public class UserDialogUser
    {
        public string? Username { get; set; }
        public string? UserGuid { get; set; }
        public decimal? UserId { get; set; }
    }
    
    private readonly IServiceProvider _serviceProvider;
    [ObservableProperty] private ObservableCollection<UserDialogUser> _users;
    [ObservableProperty] private UserDialogUser? _selectedUser;

    public AnalysisModeUserDialogViewModel(IServiceProvider serviceProvider) 
    {
        _serviceProvider = serviceProvider;

        SelectedUser = new UserDialogUser()
        {
            Username = "",
            UserGuid = "Loading users please wait",
            UserId = 0
        };

        WeakReferenceMessenger.Default.Register<AnalysisModeUserDialogViewModel, GetDatabaseUsersMessage>(this, (r, m) =>
        {
            try
            {
                GetDatabaseUsersAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error querying database for users {ex.Message}"); //TODO
            }
        });
        PopulateUsers = PopulateUsersAsync;
    }

    [RelayCommand]
    public void OnConfirm() => WeakReferenceMessenger.Default.Send(new ConfirmDatabaseUserMessage());
    [RelayCommand]
    public void OnCancel() => SendCloseMessage();
    public Func<string?,CancellationToken,Task<IEnumerable<object>>> PopulateUsers { get; }

    private async Task<IEnumerable<object>> PopulateUsersAsync(string? text, CancellationToken token)
    {
        return from user in Users.Where(user => user.Username is not null ? user.Username.Contains(text ?? "", StringComparison.OrdinalIgnoreCase) : false )
            select user;
    }

    private async Task GetDatabaseUsersAsync()
    {
        await Task.Run(() =>
        {
            FusionContext? db = _serviceProvider.GetService<FusionContext>();
            Users = new ObservableCollection<UserDialogUser>(
                from user in db!.PerUsers.Where(user => user.ActiveFlag == "Y")
                                         .Select(u => new { u.Username, u.UserGuid, u.UserId})
                select new UserDialogUser()
                {
                    Username = user.Username,
                    UserGuid = user.UserGuid,
                    UserId = user.UserId
                });
            SelectedUser = null;
        });
    }

    protected override void SendCloseMessage()
    {
        WeakReferenceMessenger.Default.Send<AnalysisModeUserDialogCloseMessage>();
    }

}