using System;
using System.Windows.Forms;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Procedures.Model;
using Procedures.Services;

namespace Procedures.ViewModel;

[INotifyPropertyChanged]
public partial class GamesListViewModel : BaseViewModel
{
    private readonly AppDbContext _dbContext;

    public GamesListViewModel(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [RelayCommand]
    private void AddPlayer()
    {
       
    }
}