using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        internal partial class Options
        {
            public Options(MainWindow _mainWindow)
            {
                mainWindow = _mainWindow;
            }

            public Options(MainWindow mainWindow, Calculator_Mode calculator_Mode, Calculation_Method calculation_Method,
                double intitial_Height, double intial_Width, Number_Notation number_Notation, char comma_Type,
                Font_Size_Type font_Size_Type, Numeral_System current_Numeral_System, 
                Languages current_Language) : this(mainWindow)
            {
                Calculator_Mode = Calculator_Mode;
                Calculation_Method = Calculation_Method;
                Intitial_Height = Intitial_Height;
                Intial_Width = Intial_Width;
                Number_Notation = Number_Notation;
                Comma_Type = Comma_Type;
                Font_Size_Type = Font_Size_Type;
                Current_Numeral_System = Current_Numeral_System;
                Current_Language = Current_Language;
            }

            public Options(MainWindow mainWindow, Options options) : this(mainWindow, options.Calculator_Mode,
                options.Calculation_Method, options.Intitial_Height, options.Intial_Width, options.Number_Notation,
                options.Comma_Type, options.Font_Size_Type, options.Current_Numeral_System, options.Current_Language)
            { }
        }
}
