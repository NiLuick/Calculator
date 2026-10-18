using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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