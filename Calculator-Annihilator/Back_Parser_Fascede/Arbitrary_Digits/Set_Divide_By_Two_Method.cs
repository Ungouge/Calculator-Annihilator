using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        private partial class Arbitrary_Digits
        {
            /// <summary>
            /// Sets as delegate method to divide arbitrary digits list by two, dependent of given numeral system.
            /// </summary>
            private Divide_By_Two_Method_Delegate Set_Divide_By_Two_Method()
            {
                if ((numeral_System % 2) == 1)
                {
                    return Divide_By_Two_Method_Odd;
                }
                else
                {
                    return Divide_By_Two_Method_Even;
                }
            }
        }
    }
}
