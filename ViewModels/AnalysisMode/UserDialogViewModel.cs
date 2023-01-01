using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using esquire.Data;
using esquire.Services.Repositories;

namespace esquire.ViewModels.AnalysisMode;

public class UserDialogCloseMessage : DialogCloseMessage { }
public class ConfirmDatabaseUserMessage { }

public partial class UserDialogViewModel : ViewModelBase
{

    private readonly IBusinessUnitsRepository _businessUnitsRepository;
    
    [ObservableProperty] private List<UserDto>? _users;
    [ObservableProperty] private UserDto? _selectedUser;

    public UserDialogViewModel(IBusinessUnitsRepository businessUnitsRepository)
    {
        _businessUnitsRepository = businessUnitsRepository;
        
        SelectedUser = new UserDto
        {
            Username = "",
            UserGuid = "Loading users please wait",
            UserId = 0
        };

        PopulateUsers = PopulateUsersAsync;
    }
    
    [RelayCommand]
    public void OnConfirm() => WeakReferenceMessenger.Default.Send(new ConfirmDatabaseUserMessage());
    [RelayCommand]
    public void OnCancel() => WeakReferenceMessenger.Default.Send(new UserDialogCloseMessage());
    public Func<string?,CancellationToken,Task<IEnumerable<object>>> PopulateUsers { get; }

    public async Task UpdateDatabaseUsersAsync()
    {
        try
        {
            Users = await _businessUnitsRepository.GetUsersAsync();
            SelectedUser = null;
        }
        catch (Exception ex)
        {
            string error = $"Error querying database for users {ex.Message}\n{ex.StackTrace}";
            Console.WriteLine(error);
        }
    }

    private async Task<IEnumerable<object>> PopulateUsersAsync(string? text, CancellationToken token)
    {
        return from user in Users?.Where(user => user.Username?.Contains(text ?? "", StringComparison.OrdinalIgnoreCase) ?? false )
            select user;
    }
}