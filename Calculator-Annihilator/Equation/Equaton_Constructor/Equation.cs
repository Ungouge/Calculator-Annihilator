using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
	public partial class Equation //constructor
	{
		public Equation ( string eq, Numeral_System ns )
		{
				the_Equation = eq;
				_Numerical_System = ns;

				Element_Selector();
			try
			{
				Integrity_Check();
			}
			catch (EquationIsEmptyException) { }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " " + the_Equation + " '" + Recreate_Equation() + "' " + ex.Message);
			}


			Bracket_Pairer();
		}
	}
}