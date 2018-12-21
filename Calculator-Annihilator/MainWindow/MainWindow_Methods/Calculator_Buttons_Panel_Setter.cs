using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Sets buttons' templates for Calcolator buttons panel.
        /// </summary>
        internal void Calculator_Buttons_Panel_Setter()
        {

            NumberKeys_ContextControl.DataContext = new Less_Than_Decimal_System(this);
            BasicOperations_ContextControl.DataContext = new Basic_Operations_Less_Than_Decimal_System(this);
            AdvancedOperations_ContextControl.DataContext = null;

            //if (Numeral_System < 1)
            //{
            //    throw new NotImplementedException();
            //}
            //else if (Numeral_System < 11)
            //{
            //    NumberKeys_Panel.DataContext = new Less_Than_Decimal_System(this);
            //    BasicOperations_Panel.DataContext = new Basic_Operations_Less_Than_Decimal_System(this);
            //    AdvancedOperations_Panel.DataContext = null;
            //}
            //else if (Numeral_System < 26)
            //{
            //    NumberKeys_Panel.DataContext = new Less_Than_Hexadecimal_System(this);
            //    BasicOperations_Panel.DataContext = new Basic_Operations_Less_Than_Hexadecimal_System(this);
            //    AdvancedOperations_Panel.DataContext = null;
            //}
            //else
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}
