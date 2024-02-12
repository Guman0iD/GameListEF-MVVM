using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Procedures.Messages;
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
        LoadGamesFromFile();
        WeakReferenceMessenger.Default.Register<SendAccountMessage>(this,  
            (sender, message) =>
        {
            EnterPlayer = message.EnteredPlayer;
        }); /////Сраный мессендежр регестраация ???
    }
    [ObservableProperty]
    private Account _enterPlayer = null!;

    
    private void LoadGamesFromFile()
    {
        string _filePath = "StoreGames.json";
        string jsonContent = File.ReadAllText(_filePath);

        var data = JsonConvert.DeserializeObject<List<Game>>(jsonContent);

        if (data != null)
        {
            foreach (var item in data)
            {
                bool isDuplicate = _dbContext.Games.Any(g => g.Name == item.Name);
                if (!isDuplicate)
                {
                    _dbContext.Games.Add(item);
                }
                else
                {
                    return;
                }
            }

            _dbContext.SaveChanges();
        }
    }

   


    [RelayCommand]
    private void RemoveAcc()
    {
        try
        {
            _dbContext.Entry(EnterPlayer)
                .Reference(a => a.Player)
                .Load();
            _dbContext.Accounts.Remove(EnterPlayer);
            _dbContext.SaveChanges();
            MessageBox.Show("ВРоде удалил");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
    }
}