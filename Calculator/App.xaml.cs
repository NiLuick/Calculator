using System.Windows;

namespace Calculator;

/// <summary>
/// Interaction logic for App.xaml The App launches the Calculator Window whith its View Model
/// </summary>

public partial class App : System.Windows.Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
 
        var viewModel = new CalculatorWindowViewModel();
        var mainWindow = new CalculatorWindow(viewModel);
        
        mainWindow.Show();
    }
}