using CommunityToolkit.Mvvm.ComponentModel;

namespace Procedures.Model;

public partial class Account : ObservableObject
{
    [ObservableProperty] 
    private int _id;

    [ObservableProperty]
    private string _login = null!;
    
    [ObservableProperty] 
    private string _hashPass = null!;
    
    public int PlayerId { get; set; }
    public Player Player { get; set; } = null!;
}