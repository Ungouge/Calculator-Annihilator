using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Positional_Back_Parser
        {
            public string Get_Coeficient
            {
                get
                {
                    return Digit_List_In_Numeral_System_To_String(Arbitrary_Digits.Get_Coefficients);
                }
            }

            public short Get_Exponent_Value
            {
                get
                {
                    return Arbitrary_Digits.Get_Comma_Position;
                }
            }

            public byte Numeral_System_Precition
            {
                get
                {
                    return Arbitrary_Digits.Numeral_System_Precition;
                }
            }

            public sbyte Numeral_System_Type
            {
                get
                {
                    return Arbitrary_Digits.Numeral_System_Type;
                }
            }
        }
    }
}
