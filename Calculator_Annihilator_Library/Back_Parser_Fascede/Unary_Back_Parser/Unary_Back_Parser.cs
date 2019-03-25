using System;

namespace Calculator_Annihilator_Library
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
