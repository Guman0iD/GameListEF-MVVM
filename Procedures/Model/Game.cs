using System.Collections;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Procedures.Model;

public partial class Game : ObservableObject
{
    [ObservableProperty]
    private int _id;

    [ObservableProperty] 
    private string _name = null!;
    
    [ObservableProperty]
    private string _genre = null!;

    [ObservableProperty]
    private string _publisher = null!;

    [ObservableProperty]
    private double _price;
    
    private ICollection<Player> Players { get; set; } = null!;
}