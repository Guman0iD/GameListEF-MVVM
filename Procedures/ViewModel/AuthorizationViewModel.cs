using System;
using System.Linq;
using System.Windows.Forms;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Procedures.Messages;
using Procedures.Model;
using Procedures.Services;
using Procedures.View;

namespace Procedures.ViewModel;

[INotifyPropertyChanged]
public partial class AuthorizationViewModel : BaseViewModel
{
    private readonly AppDbContext _dbContext;

    public AuthorizationViewModel(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    [ObservableProperty]
    private string? _enteredPass;
    [ObservableProperty]
    private string? _enteredLogin;

    [RelayCommand]
    private void SignIn()
    {
        try
        {
            var account = _dbContext.Accounts.Include(account => account.Player).FirstOrDefault(a => a.Login == EnteredLogin);
            if (account != null)
            {
                var verifyPass = EnteredPass != null && HashPass.VerifyPass(EnteredPass, account.HashPass);
                MessageBox.Show(verifyPass ? $"Hello {account.Player.FirstName}" : "Password is wrong!");
            }
            else
            {
                MessageBox.Show("User not found!");
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"{e}");
            throw;
        }
    }


    [RelayCommand]
    private void RegisterAcc()
    {
        WeakReferenceMessenger.Default.Send(
            new ChangeViewModelMessage(App.ServiceProvider.GetService<RegisterViewModel>()!));
    }
}