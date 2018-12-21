using System;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		/// <summary>
		/// Creates new numerical system for main window.
		/// </summary>
		/// <param name="ns">Base of new numeral system or encoded number for exotic numeral system(check Numerical_System description).</param>
		internal void Set_Current_Numerical_System(sbyte new_Numeral_System_Base)
		{
			Current_Numeral_System = new Numeral_System(new_Numeral_System_Base);
		}
	}
}
