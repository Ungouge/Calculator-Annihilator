using System;

namespace Calculator_Annihilator
{
	partial class Options
	{
		/// <summary>
		/// Creates new numerical system for main window.
		/// </summary>
		/// <param name="ns">Base of new numeral system or encoded number for exotic numeral system(check Numerical_System description).</param>
		private void Set_Numeral_System(sbyte new_Numeral_System_Base)
		{
			Current_Numeral_System = new Numeral_System(new_Numeral_System_Base);

            Parser = new Parser(Current_Numeral_System);
		}
	}
}
