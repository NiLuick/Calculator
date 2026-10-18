using Calculator.MVVMHelperClasses;

namespace Calculator;

/// <summary>
/// View Model for the Calculator Window
/// </summary>

public class CalculatorWindowViewModel : ViewModelBase
{
    // Defining local Variables
    private string _outputField = "123456";
    
    public CalculatorWindowViewModel()
    {}
    
    // Properties for the Window
    public string OutputField
    {
        get
        {
            return _outputField;
        }
        set
        {
            _outputField = value;
        }
    }
}