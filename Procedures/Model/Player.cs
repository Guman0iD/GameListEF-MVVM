using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Procedures.Model;

public partial class Player : ObservableValidator
{
    [ObservableProperty]
    [Key]
    private int _id;

    [ObservableProperty]
    [MaxLength(128)] 
    private string _firstName = null!;

    [ObservableProperty, MaxLength(128)]
    private string _lastName = null!;
    
    [ObservableProperty, MaxLength(128)]
    private string _mail = null!;

    [ObservableProperty] 
    private DateTime _birthDate;

    public ICollection<Account> Accounts { get; set; } = null!;
    public ICollection<Game> Games { get; set; } = null!;
}