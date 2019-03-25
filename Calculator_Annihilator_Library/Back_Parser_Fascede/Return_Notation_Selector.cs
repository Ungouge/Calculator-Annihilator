using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    partial class Back_Parser_Fascede
    {
        private string Return_Notation_Selector(IBack_Parser Back_Parser, Number_Notation Number_Notation, string comma_Type)
        {
            switch (Number_Notation)
            {
                case Number_Notation.Normal:
                    return Return_Normal_Notation(Back_Parser, comma_Type);
                case Number_Notation.Scienfic_Normalized:
                    return Return_Scienfic_Normalized_Notation(Back_Parser, comma_Type);
                case Number_Notation.Force_Radix_Base:
                    return Return_Force_Radix_Base_Notation(Back_Parser, comma_Type);
                case Number_Notation.Force_Scientific:
                    return Return_Force_Scientific_Notation(Back_Parser, comma_Type);
                case Number_Notation.Force_Exponent:
                    return Return_Force_Exponent_Notation(Back_Parser, comma_Type);
                case Number_Notation.Engineering:
                    return Return_Engineering_Notation(Back_Parser, comma_Type);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}