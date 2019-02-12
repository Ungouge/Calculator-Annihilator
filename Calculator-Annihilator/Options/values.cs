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

        internal Font_Size_Type Font_Size_Type { get; set; }

        private sbyte numeral_System_Code;

        internal sbyte Numeral_System_Code
        {
            get
            {
                return numeral_System_Code;
            }
            set
            {
                numeral_System_Code = value;

                Set_Numeral_System(value);
            }
        }

        internal Parser Parser { get; private set; }

        internal Numeral_System Current_Numeral_System { get; private set; }

        private Languages current_Language;

        internal Languages Current_Language
        {
            get
            {
                return current_Language;
            }
            set
            {
                current_Language = value;

                Set_Language(value);
            }
        }

        internal Standard_Messages Standard_Messages { get; private set; }

    }
}

