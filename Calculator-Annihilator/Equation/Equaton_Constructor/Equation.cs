using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
	public partial class Equation
	{
		public Equation ( string eq, Numerical_System ns )
		{
			try
			{
				the_Equation = eq;
				_Numerical_System = ns;

				Element_Selector();
				Integrity_Check(Elements_Colection);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			Bracket_Pairer();
		}
	}
}