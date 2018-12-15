using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Class to solving given text string parsing to switch calculation mode to single by solving more complex one
        /// or single operation as it would be weitten in single mode.
        /// </summary>
        private partial class Complex_To_Single_WorkSpace_Converter : Equation
        {
            MainWindow MainWindow;

            /// <summary>
            /// Constructs new instance of Converter converting given text string parsing to switch calculation mode
            /// to single by solving more complex one or single operation as it would be weitten in single mode.
            /// </summary>
            internal Complex_To_Single_WorkSpace_Converter(string equation, Numeral_System numeral_System, MainWindow _MainWindow) 
                : base(equation, numeral_System)
            {
                MainWindow = _MainWindow;
            }
        }
    }
}
