using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Dynamic_Parameters : Window_Dynamic_Parameters
        {
            private Calculation_Method _Calculation_Method;

            public Calculation_Method Calculation_Method
            {
                get {
                    return _Calculation_Method;
                }
                set {
                    _Calculation_Method = value;
                }
            }

        }
    }
}