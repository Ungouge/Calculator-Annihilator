using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
	/// <summary>
	/// Constructs given string to equation elements list.
	/// </summary>
	public partial class Equation //constructor
	{
		/// <summary>
		/// Constructs given string to equation elements list, finds mistakes and correct them 
		/// </summary>
		/// <param name="eq">String that will be convert to equation elements list.</param>
		/// <param name="ns">Numeral system </param>
		public Equation ( string eq, Numeral_System ns )
		{
			the_Equation = eq;
			_Numerical_System = ns;

			Element_Selector();

			try
			{
				Integrity_Check();
			}
			catch (EquationIsEmptyException)
			{
				Element_Colection = new Equation_Elements { new Number(0) };
			}

			Bracket_Pairer();
		}
	}
}