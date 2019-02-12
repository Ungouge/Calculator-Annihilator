using System;

namespace Calculator_Annihilator
{
    internal partial class Options
    {
        /// <summary>
        /// Constructs new Otpions class reading and setting resorcess for MainWindow .
        /// </summary>
        public Options(Calculator_Mode calculator_Mode, Calculation_Method calculation_Method,
            double intitial_Height, double intial_Width, Number_Notation number_Notation, string comma_Type,
            Font_Size_Type font_Size_Type, sbyte numeral_System_Code,
            Languages current_Language)
        {
            Calculator_Mode = calculator_Mode;
            Calculation_Method = calculation_Method;
            Intitial_Height = intitial_Height;
            Intial_Width = intial_Width;
            Number_Notation = number_Notation;
            Comma_Type = comma_Type;
            Font_Size_Type = font_Size_Type;
            Numeral_System_Code = numeral_System_Code;
            Current_Language = current_Language;
        }

        public Options(Options options) : this(options.Calculator_Mode,
            options.Calculation_Method, options.Intitial_Height, options.Intial_Width, options.Number_Notation,
            options.Comma_Type, options.Font_Size_Type, options.Numeral_System_Code, options.Current_Language)
        { }
    }
}
