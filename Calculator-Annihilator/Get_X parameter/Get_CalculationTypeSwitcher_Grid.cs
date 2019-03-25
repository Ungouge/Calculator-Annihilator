using System;
using System.Windows.Controls;
using IMain_Window;

namespace Calculator_Annihilator
{
    partial class MainWindow: IMainWindow_Calculation_Method_Switcher
    {
        public Grid Get_CalculationTypeSwitcher_Grid
        {
            get
            {
                return CalculationTypeSwitcher_Grid;
            }
        }
    }
}
