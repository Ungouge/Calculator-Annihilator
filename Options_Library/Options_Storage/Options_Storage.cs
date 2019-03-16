using System;
using Common_Library;

namespace Options_Library
{
    public partial class Options_Storage
    {
        /// <summary>
        /// Constructs new Otpions class reading and setting resorcess for MainWindow .
        /// </summary>
        public Options_Storage(Calculator_Mode calculator_Mode, Calculation_Method calculation_Method,
            double intitial_Height, double intial_Width, Number_Notation number_Notation, string comma_Type,
            Font_Size_Type font_Size_Type, sbyte numeral_System_Code, Languages current_Language) 
            : this(calculator_Mode, calculation_Method,intitial_Height,intial_Width, number_Notation, font_Size_Type)
        {
            Comma_Type = comma_Type;
            Numeral_System_Code = numeral_System_Code;
            Current_Language = current_Language;
            //set_language
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
    }
}
