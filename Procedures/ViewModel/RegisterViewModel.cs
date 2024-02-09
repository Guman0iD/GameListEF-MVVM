using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Procedures.Messages;
using Procedures.Model;
using Procedures.Services;

namespace Procedures.ViewModel;

[INotifyPropertyChanged]
public partial class RegisterViewModel : BaseViewModel
{
    private readonly AppDbContext _dbContext;
    public Account NewAccount { get; }
    public Player NewPlayer { get; }
    
    public RegisterViewModel(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        NewAccount = new Account();
        NewPlayer = new Player();
    }

    [RelayCommand]
    private void Back()
    {
        WeakReferenceMessenger.Default.Send(new ChangeViewModelMessage(App.ServiceProvider.GetService<AuthorizationViewModel>()!));
    }

    [RelayCommand]
    private void Register()
    {
        try
        {
            _dbContext.Accounts.Add(new Account()
            {
                Login = NewAccount.Login,
                HashPass = HashPass.HashPassword(NewAccount.HashPass),
                Player = NewPlayer
            });

            _dbContext.SaveChanges();
            Back();
        }
        catch (Exception e)
        {
            System.Windows.Forms.MessageBox.Show($"{e}");
            throw;
        }
      
        
        
    }
}