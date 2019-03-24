using System;
using System.Text;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        /// <summary>
        /// Returns given number as string in form of number always rooted on zeroeth order of magnitude.
        /// </summary>
        private string Return_Force_Radix_Base_Notation(IBack_Parser Back_Parser, string comma_Type)
        {
            // Force radix base notation expresses number always rooted on (radix) zeroeth
            // order of magnitude no matter how many zeroes may need to print it.
            // In simplier cases the comma sign will be placed among digits or will be not printed
            // at all in cases of integer numbers not divisible by base of their numeral sytem.
            // Normalized notations methods in those simplier cases will call this method
            // to return forced radix base notation.

            StringBuilder output = new StringBuilder();

            if (Back_Parser.Get_Exponent_Value < 0)
            {
                output.Append("0,");

                for (int i = Back_Parser.Get_Exponent_Value + 1; i < 0; i++)
                    output.Append(0);

                output.Append(Back_Parser.Get_Coeficient);
            }
            else
            {
                output.Append(Back_Parser.Get_Coeficient);

                short comma_Position = (short)(Back_Parser.Get_Exponent_Value - output.Length + 1);

                if (comma_Position < 0)
                {
                    output.Insert(Back_Parser.Get_Exponent_Value + 1, comma_Type);
                }
                else if (comma_Position > 0)
                {
                    for (int i = 0; i < comma_Position; i++)
                    {
                        output.Append(0);
                    }
                }
            }

            return output.ToString();
        }
    }
}
