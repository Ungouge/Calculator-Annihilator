using System;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Fascede class to manage parsing from double precition floating point numbers to string
    /// representation of a number according to current settings of the calculator.
    /// </summary>
    public partial class Back_Parser_Fascede
    {
        MainWindow MainWindow;

        /// <summary>
        /// Constructs a class to manage parsing from double precition floating point numbers to string
        /// representation of a number according to current settings of the calculator. Passing 
        /// pointer to calculator to get current setting of the calculator.
        /// </summary>
        public Back_Parser_Fascede(MainWindow _MainWindow)
        {
            MainWindow = _MainWindow;
        }
    }
}
