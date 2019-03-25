using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        partial class Arbitrary_Digits
        {
            /// <summary>
            /// Divides arbitrary digit list by two.
            /// </summary>
            private void Divide_By_Two()
            {
                _Divide_By_Two_Method_Delegate();
            }

            /// <summary>
            /// Divides arbitrary digit list by two, for numbers in even positional numeral system.
            /// </summary>
            private void Divide_By_Two_Method_Even()
            {
                byte[] New_Digit_Array = new byte[Digit_List.Count];

                byte rest = 0;

                for (int i = 0; i < Digit_List.Count; i++)
                {
                    short new_Digit_Value =
                        (short)((Digit_List[i] * half_Of_Numeral_System) + rest);

                    New_Digit_Array[i] = (byte)(new_Digit_Value % numeral_System);

                    rest = (byte)(new_Digit_Value / numeral_System);
                }

                List<byte> New_Digit_List = New_Digit_Array.ToList();

                if (rest != 0)
                {
                    New_Digit_List.Add(rest);
                }
                else
                {
                    Comma_Position--;
                }

                Digit_List = Normalize(New_Digit_List);
            }


            /// <summary>
            /// Divides arbitrary digit list by two, for numbers in odd positional numeral system.
            /// </summary>
            private void Divide_By_Two_Method_Odd()
            {
                List<byte> New_Digit_List = new List<byte>();

                bool divition_Rest;

                int last_Digit = Digit_List.Count - 1;
                
                if (Digit_List[last_Digit] > 1)
                {
                    New_Digit_List.Add((byte)(Digit_List[last_Digit] / 2));
                    divition_Rest = Digit_List[last_Digit] % 2 == 1;
                }
                else
                {
                    Comma_Position--;
                    divition_Rest = Digit_List[last_Digit] == 1;
                }

                for (int i = last_Digit - 1; i >= 0; i--)
                {
                    if (divition_Rest == false)
                    {
                        New_Digit_List.Add((byte)(Digit_List[i] / 2));

                        divition_Rest = Digit_List[i] % 2 == 1;
                    }
                    else
                    {
                        New_Digit_List.Add((byte)((Digit_List[i] + numeral_System) / 2));

                        divition_Rest = Digit_List[i] % 2 == 0;
                    }
                }

                if (divition_Rest == true)
                {
                    while (New_Digit_List.Count <= precition - binary_Exponent)
                    {
                        New_Digit_List.Add(half_Of_Numeral_System);
                    }
                }

                New_Digit_List.Reverse();

                Digit_List = Normalize(New_Digit_List);
            }
        }
    }
}