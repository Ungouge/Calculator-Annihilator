using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        private partial class Arbitrary_Digits
        {
            protected internal List<byte> Get_Coefficients
            {
                get
                {
                    return Digit_List;
                }
            }

            protected internal short Get_Comma_Position
            {
                get
                {
                    return Comma_Position;
                }
            }

            protected internal sbyte Numeral_System_Type
            {
                get
                {
                    return numeral_System;
                }
            }
        }
    }
}
