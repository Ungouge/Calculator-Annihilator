using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    partial class Back_Parser_Fascede
    {
        private partial class Unary_Back_Parser
        {
            private void Set_Number_To_String()
            {
                if (number <= 0)
                    Number_To_String = "";
                else if (number < 1)
                    Number_To_String = "1";
                else
                {
                    int number_As_Interger;

                    if (number < Int32.MaxValue)
                        number_As_Interger = (int)Math.Round(number);
                    else
                        number_As_Interger = Int32.MaxValue;

                    StringBuilder output = new StringBuilder("");

                    for(int i = 0 ; i < number_As_Interger; i++)
                    {
                        output.Append('1');
                    }

                    Number_To_String = output.ToString();
                }
            }
        }
    }
}
