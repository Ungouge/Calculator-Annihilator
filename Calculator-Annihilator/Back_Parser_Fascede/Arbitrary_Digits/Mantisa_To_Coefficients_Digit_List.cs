using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Calculates number coeficient as digit list in given positional numeral system.  
            /// </summary>
            private void Mantisa_To_Coefficients_Digit_List()
            {
                Digit_List = new List<byte>() { 0 };

                for (int i = 0; i < 53; i++)
                {
                    long currently_Added_Binary_Position = 1L << i;

                    if ((mantissa & currently_Added_Binary_Position) != 0)
                    {
                        Add_Binary_Position(currently_Added_Binary_Position);
                    }
                }

                Comma_Position += (short)(Digit_List.Count - 1);

                Digit_List = Normalize();
            }

            /// <summary>
            /// Adds given binary part of mantissa to arbitrary digit list as number in given positional numeral system.
            /// </summary>
            /// <param name="currently_Added_Binary_Position"></param>
            private void Add_Binary_Position(long currently_Added_Binary_Position)
            {
                byte Digit_List_Current = 0;

                bool is_Last_Loop;

                do
                {
                    Digit_List[Digit_List_Current] +=
                        (byte)(currently_Added_Binary_Position % numeral_System);

                    bool do_Push_Forward = Do_Push_Forward(Digit_List_Current);

                    currently_Added_Binary_Position /= numeral_System;

                    is_Last_Loop = currently_Added_Binary_Position < 1;

                    if (++Digit_List_Current >= Digit_List.Count)
                    {
                        if (do_Push_Forward == true)
                            Digit_List.Add(1);
                        else if (is_Last_Loop == false)
                            Digit_List.Add(0);
                    }
                    else if (do_Push_Forward == true)
                        Digit_List[Digit_List_Current]++;

                } while (is_Last_Loop == false);
            }

            /// <summary>
            /// Checks does counted digit is to big for given numeral system, if so adjust it and passed true as inforamtion for callin method.
            /// </summary>
            private bool Do_Push_Forward(byte Digit_List_Current)
            {
                if (Digit_List[Digit_List_Current] >= numeral_System)
                {
                    Digit_List[Digit_List_Current] = (byte)(Digit_List[Digit_List_Current] - numeral_System);

                    return true;
                }

                return false;
            }
        }
    }
}
