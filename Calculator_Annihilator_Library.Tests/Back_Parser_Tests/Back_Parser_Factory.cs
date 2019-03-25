using System;
using Common_Library;

namespace Calculator_Annihilator_Library.Tests
{
    internal class Back_Parser_Factory
    {
        private readonly Back_Parser_Fascede Back_Parser_Fascede;

        /// <summary>
        /// Constructs new Factory for getting Back_Parser_Fascede for test not requiring a comma sign.
        /// </summary>
        internal Back_Parser_Factory(Number_Notation number_Notation,
            sbyte numeral_System_Type) : this(number_Notation, numeral_System_Type, String.Empty)
        {
        }

        /// <summary>
        /// Constructs new Factory for getting Back_Parser_Fascede.
        /// </summary>
        internal Back_Parser_Factory(Number_Notation number_Notation, sbyte numeral_System_Type, string comma_Type)
        {
            Back_Parser_Fascede = new Back_Parser_Fascede(number_Notation, numeral_System_Type, comma_Type);
        }

        /// <summary>
        /// Gets Back_Parser_Fascede accorging to parameter given in constructor.
        /// </summary>
        internal Back_Parser_Fascede Get_Back_Parser
        {
            get
            {
                return Back_Parser_Fascede;
            }
        }
    }
}
