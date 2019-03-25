using System;
using Calculator_Annihilator_Library;
using Common_Library;

namespace Calculator_Annihilator_Library
{
	partial class Options
	{
		/// <summary>
		/// Creates new numerical system for main window.
		/// </summary>
		/// <param name="ns">Base of new numeral system or encoded number for exotic numeral system(check Numerical_System description).</param>
		public void Set_Numeral_System(sbyte new_Numeral_System_Code)
		{
            Numeral_System_Code = new_Numeral_System_Code;

            Current_Numeral_System = new Numeral_System(Numeral_System_Code);

            Parser = new Parser(Current_Numeral_System);

            Back_Parser = new Back_Parser_Fascede(Number_Notation, Numeral_System_Code, Comma_Type);
        }
	}
}
