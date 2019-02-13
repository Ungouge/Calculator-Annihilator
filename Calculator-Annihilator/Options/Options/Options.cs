using System;

namespace Calculator_Annihilator
{
    internal partial class Options : Options_Storage
    {
        /// <summary>
        /// Constructs new Options class reading and setting resorcess for MainWindow .
        /// </summary>
        public Options(MainWindow mainWindow , Options_Storage options) : base(options.Calculator_Mode,
            options.Calculation_Method, options.Initial_Height, options.Initial_Width,
            options.Number_Notation, options.Font_Size_Type)
        {
            Current_MainWindow = mainWindow;
            Set_Comma_Type(options.Comma_Type);
            Set_Numeral_System(options.Numeral_System_Code);
            Set_Language(options.Current_Language);
        }
    }
}
