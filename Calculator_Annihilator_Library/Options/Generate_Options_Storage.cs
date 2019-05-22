using System;
using Options_Library;

namespace Calculator_Annihilator_Library
{
    partial class Options
    {
        internal Options_Storage Generate_Options_Storage()
        {
            return new Options_Storage(Calculator_Mode, Calculation_Method, Initial_Height, Initial_Width,
                Number_Notation, Comma_Type, Font_Size_Type, Colour_Palette_Type, Numeral_System_Code, Current_Language);
        }
    }
}
