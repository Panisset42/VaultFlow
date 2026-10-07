using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace VaultFlow.ViewModel;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _panelCollapsed = "-";

    [RelayCommand]
    private void TogglePanel()
    {
        PanelCollapsed = PanelCollapsed == "-" ? "X" : "-";
    }
}