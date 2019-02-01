using System;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// 
            /// </summary>
            internal byte Numeral_System_Precition
            {
                get
                {
                    return (byte)(Math.Ceiling(52 * (Math.Log(2, numeral_System))) + 1);
                }
            }
        }
    }
}
