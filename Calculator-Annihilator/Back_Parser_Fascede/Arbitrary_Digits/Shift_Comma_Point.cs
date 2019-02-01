using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Controlls adjusting arbitrary digits list by binary exponent of number to exponent of given numeral system.
            /// </summary>
            private void Shift_Comma_Point()
            {
                while (binary_Exponent != 0)
                {
                    if (binary_Exponent > 0)
                    {
                        Muliply_By_Two();

                        binary_Exponent--;
                    }
                    else
                    {
                        Divide_By_Two();

                        binary_Exponent++;
                    }
                }
            }
        }
    }
}
