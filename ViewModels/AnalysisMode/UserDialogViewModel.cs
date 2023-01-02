using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using esquire.Data;
using esquire.Services.Repositories;
using HanumanInstitute.MvvmDialogs;

namespace esquire.ViewModels.AnalysisMode;

public partial class UserDialogViewModel : ViewModelBase, IModalDialogViewModel, ICloseable
{

    private readonly IBusinessUnitsRepository _businessUnitsRepository;
    
    [ObservableProperty] private List<UserDto>? _users;
    [ObservableProperty] private UserDto? _selectedUser;
    [ObservableProperty] private bool? _dialogResult;

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

    public event EventHandler? RequestClose;
    
    [RelayCommand]
    public void OnConfirm()
    {
        DialogResult = true;
        RequestClose?.Invoke(this, EventArgs.Empty);
    }
    [RelayCommand]
    public void OnCancel()
    {
        DialogResult = false;
        RequestClose?.Invoke(this, EventArgs.Empty);
    }

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