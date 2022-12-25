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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels;

public class AnalysisModeUserDialogCloseMessage : DialogCloseMessage {}
public class GetDatabaseUsersMessage { }
public class ConfirmDatabaseUserMessage { }

public partial class AnalysisModeUserDialogViewModel : ViewModelBase
{
    public class UserDialogUser
    {
        public string? Username { get; set; }
        public string? UserGuid { get; set; }
        public decimal? UserId { get; set; }
    }
    
    [ObservableProperty] private ObservableCollection<UserDialogUser> _users;
    [ObservableProperty] private UserDialogUser? _selectedUser;

    public AnalysisModeUserDialogViewModel() 
    {

        SelectedUser = new UserDialogUser()
        {
            Username = "",
            UserGuid = "Loading users please wait",
            UserId = 0
        };

        WeakReferenceMessenger.Default.Register<GetDatabaseUsersMessage>(this, (r, m) => GetDatabaseUsersAsync());
        
        PopulateUsers = PopulateUsersAsync;
    }
    
    [RelayCommand]
    public void OnConfirm() => WeakReferenceMessenger.Default.Send(new ConfirmDatabaseUserMessage());
    [RelayCommand]
    public void OnCancel() => WeakReferenceMessenger.Default.Send(new AnalysisModeUserDialogCloseMessage());
    public Func<string?,CancellationToken,Task<IEnumerable<object>>> PopulateUsers { get; }

    private async Task<IEnumerable<object>> PopulateUsersAsync(string? text, CancellationToken token)
    {
        return from user in Users.Where(user => user.Username?.Contains(text ?? "", StringComparison.OrdinalIgnoreCase) ?? false )
            select user;
    }

    private async Task GetDatabaseUsersAsync() //TODO find out why this runs twice
    {
        try
        {
            Users = await Task.Run(() =>
            {
                Console.WriteLine("Fetching");
                FusionContext? db = App.Current!.Services.GetService<FusionContext>();

                return new ObservableCollection<UserDialogUser>(
                    db!.PerUsers
                        .Where(user => user.ActiveFlag == "Y")
                        .Select(u => new UserDialogUser{ Username = u.Username, UserGuid = u.UserGuid, UserId = u.UserId }).ToList());
            });
            
            SelectedUser = null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error querying database for users {ex.Message}\n{ex.StackTrace}"); //TODO
        }
    }
}