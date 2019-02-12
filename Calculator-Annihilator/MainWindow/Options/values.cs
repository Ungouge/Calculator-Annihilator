using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Options
        {
            private MainWindow mainWindow;

            internal Calculator_Mode Calculator_Mode { get; set; }

            internal Calculation_Method Calculation_Method { get; set; }

            internal double Intitial_Height { get; set; }

            internal double Intial_Width { get; set; }

            internal Number_Notation Number_Notation { get; set; }

            internal char Comma_Type { get; set; }

            internal Font_Size_Type Font_Size_Type { get; set; }

            internal Numeral_System Current_Numeral_System { get; set; }

            internal Languages Current_Language { get; set; }
        }
    }
}
