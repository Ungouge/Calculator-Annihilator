using System;

namespace Calculator_Annihilator
{
    partial class Options
    {
        internal Calculator_Mode Calculator_Mode { get; set; }

        internal Calculation_Method Calculation_Method { get; set; }

        internal double Intitial_Height { get; set; }

        internal double Intial_Width { get; set; }

        internal Number_Notation Number_Notation { get; set; }

        internal Font_Size_Type Font_Size_Type { get; set; };

        internal sbyte Numeral_System_Code { get; private set; }

        internal Parser Parser { get; private set; }

        internal Numeral_System Current_Numeral_System { get; private set; }

        internal Languages Current_Language { get; private set; }

        internal Standard_Messages Standard_Messages { get; private set; }

        internal string Comma_Type { get; private set; }

        internal string[] Commas_Type_Array { get; private set; } = Signs_Lib.Commas_Type;
    }
}

