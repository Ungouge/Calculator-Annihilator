using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Multiplies arbitrary digit list by two.
            /// </summary>
            private void Muliply_By_Two()
            {
                List<byte> New_Digit_List = new List<byte>();

                bool do_Push_Forward = false;

                foreach (byte digit in Digit_List)
                {
                    byte new_Value = (byte)(digit * 2 + (do_Push_Forward ? 1 : 0));

                    if (new_Value >= numeral_System)
                    {
                        new_Value -= (byte)numeral_System;
                        do_Push_Forward = true;
                    }
                    else
                        do_Push_Forward = false;

                    New_Digit_List.Add(new_Value);
                }

                if (do_Push_Forward == true)
                {
                    New_Digit_List.Add(1);

                    Comma_Position++;
                }

                Digit_List = Normalize(New_Digit_List);
            }
        }
    }
}
