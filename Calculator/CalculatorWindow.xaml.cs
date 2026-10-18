using System.Windows;

namespace Calculator;

/// <summary>
/// Interaction logic for CalculatorWindow.xaml
/// </summary>
 
public partial class CalculatorWindow : Window
{
    public CalculatorWindow(CalculatorWindowViewModel viewModel)
    {
        InitializeComponent();

        // Logic in the View Model
        DataContext = viewModel;
    }
}