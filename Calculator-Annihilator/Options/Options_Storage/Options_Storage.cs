using System;

namespace Calculator_Annihilator
{
    internal partial class Options_Storage
    {
        /// <summary>
        /// Constructs new Otpions class reading and setting resorcess for MainWindow .
        /// </summary>
        public Options_Storage(Calculator_Mode calculator_Mode, Calculation_Method calculation_Method,
            double intitial_Height, double intial_Width, Number_Notation number_Notation, string comma_Type,
            Font_Size_Type font_Size_Type, sbyte numeral_System_Code, sbyte[] Pined_Numeral_Systems, Languages current_Language) 
            : this(calculator_Mode,calculation_Method,intitial_Height,intial_Width, number_Notation,font_Size_Type)
        {
            Comma_Type = comma_Type;
            Numeral_System_Code = numeral_System_Code;
            Current_Language = current_Language;
        }

        public Options_Storage(Calculator_Mode calculator_Mode, Calculation_Method calculation_Method,
            double intitial_Height, double intial_Width, Number_Notation number_Notation,
            Font_Size_Type font_Size_Type)
        {
            Calculator_Mode = calculator_Mode;
            Calculation_Method = calculation_Method;
            Initial_Height = intitial_Height;
            Initial_Width = intial_Width;
            Number_Notation = number_Notation;
            Font_Size_Type = font_Size_Type;
        }

        public Options_Storage(Options options) : this(options.Calculator_Mode,
            options.Calculation_Method, options.Initial_Height, options.Initial_Width, options.Number_Notation,
            options.Comma_Type, options.Font_Size_Type, options.Numeral_System_Code, options.Pined_Numeral_Systems,
            options.Current_Language)
        { }
    }
}
