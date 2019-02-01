using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Binary_Back_Parser : IBack_Parser
        {
            public string Get_Coeficient
            {
                get
                {
                    return coeficient;
                }
            }

            public short Get_Exponent_Value
            {
                get
                {
                    return (short) (exponent);
                }
            }

            public byte Numeral_System_Precition
            {
                get
                {
                    return 53;
                }
            }

            public sbyte Numeral_System_Type
            {
                get
                {
                    return 2;
                }
            }

        }
    }
}
