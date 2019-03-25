using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    /// <summary>
    /// Fascede class to manage parsing from double precition floating point numbers to string
    /// representation of a number according to current settings of the calculator.
    /// </summary>
    public partial class Back_Parser_Fascede
    {
        Number_Notation Number_Notation;

        sbyte numeral_system_Type;

        string comma_Type;

        /// <summary>
        /// Constructs a class to manage parsing from double precition floating point numbers to string
        /// representation of a number according to current settings of the calculator. Passing 
        /// pointer to calculator to get current setting of the calculator.
        /// </summary>
        public Back_Parser_Fascede(Number_Notation _Number_Notation, sbyte _numeral_system_Type, string _comma_Type)
        {
            Number_Notation = _Number_Notation;

            numeral_system_Type = _numeral_system_Type;

            comma_Type = _comma_Type;
        }
    }
}
