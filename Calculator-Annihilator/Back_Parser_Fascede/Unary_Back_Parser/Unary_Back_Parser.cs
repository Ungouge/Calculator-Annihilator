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
            private double number;

            public Unary_Back_Parser(double _number)
            {
                number = _number;

                Set_Number_To_String();
            }
        }
    }
}
