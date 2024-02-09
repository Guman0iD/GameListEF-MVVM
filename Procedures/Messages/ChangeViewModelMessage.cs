using Procedures.ViewModel;

namespace Procedures.Messages;

public class ChangeViewModelMessage
{
    public ChangeViewModelMessage( BaseViewModel viewModel) 
    {
        ViewModel = viewModel;
    }
    public BaseViewModel ViewModel { get;}
}