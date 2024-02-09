using System.Windows;
using Procedures.ViewModel;

namespace Procedures.View;

public partial class MainView : Window
{
    public MainView(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }   
}