using System;
using System.Windows.Controls;

namespace IMain_Window
{
    public interface IMainWindow_Calculation_Method_Switcher
    {
        TextBlock Get_ComplexCalculations_TextBlock { get; }

        Grid Get_CalculationTypeSwitcher_Grid { get; }
    }
}
