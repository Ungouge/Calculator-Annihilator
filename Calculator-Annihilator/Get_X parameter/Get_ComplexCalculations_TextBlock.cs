using System;
using System.Windows.Controls;
using IMain_Window;

namespace Calculator_Annihilator
{
    partial class MainWindow: IMainWindow_Calculation_Method_Switcher
    {
        public TextBlock Get_ComplexCalculations_TextBlock
        {
            get
            {
                return ComplexCalculations_RadioButton_TextBlock;
            }
        }
    }
}
