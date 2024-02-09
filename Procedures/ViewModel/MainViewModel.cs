using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Procedures.Messages;

namespace Procedures.ViewModel;

[INotifyPropertyChanged]
public partial class MainViewModel : BaseViewModel
{

    public MainViewModel()
    {
        WeakReferenceMessenger.Default.Register<ChangeViewModelMessage>(this,
            (sender, message) =>
            {
                CurrentViewModel = message.ViewModel;
            });
        
        var viewModel = App.ServiceProvider.GetService<AuthorizationViewModel>()!; 
        
        var changeViewModelMessage = new ChangeViewModelMessage(viewModel);
        
        WeakReferenceMessenger.Default.Send(changeViewModelMessage);
    }
    
    [ObservableProperty]
    private BaseViewModel? _currentViewModel;
}