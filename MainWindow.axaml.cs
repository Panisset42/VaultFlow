using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using VaultFlow.ViewModel;
namespace VaultFlow;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

}