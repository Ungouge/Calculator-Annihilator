using System;
using Common_Library;

namespace Options_Library
{
    public interface ISet_Options
    {
        void Add_New_Comma_Type(string[] Comma_Types);

        void Set_Calculator_Mode(Calculator_Mode _Calculator_Mode);

        void Set_Calculation_Method(Calculation_Method _Calculation_Method);

        void Set_Comma_Type(string new_Comma_Type);

        void Set_Font_Size_Type(Font_Size_Type new_Font_Size_Type);

        void Set_Language(Languages new_Language);

        void Set_Number_Notation(Number_Notation new_Number_Notation);

        void Set_Numeral_System(sbyte new_Numeral_System_Code);
    }
}
