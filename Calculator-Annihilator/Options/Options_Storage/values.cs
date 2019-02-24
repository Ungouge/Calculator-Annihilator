using System;

namespace Calculator_Annihilator
{
    partial class Options_Storage
    {
        protected internal Calculator_Mode Calculator_Mode { get; set; }

        protected internal Calculation_Method Calculation_Method { get; set; }

        protected internal double Initial_Height { get; set; }

        protected internal double Initial_Width { get; set; }

        protected internal Number_Notation Number_Notation { get; set; }

        protected internal Font_Size_Type Font_Size_Type { get; set; }

        protected internal sbyte Numeral_System_Code { get; protected set; }

        protected internal sbyte[] Pined_Numeral_Systems { get; protected set; }

        protected internal Languages Current_Language { get; protected set; }

        protected internal string Comma_Type { get; protected set; }
    }
}