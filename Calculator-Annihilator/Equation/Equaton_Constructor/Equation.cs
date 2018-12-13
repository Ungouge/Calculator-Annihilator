﻿using System;
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
                MessageBox.Show("Given equation to solve is empty or correction of incorrectly written equation " +
                    "text left no elements in the equation.");
                Element_Colection = new Equation_Elements { new Number(0) };
			}

			Bracket_Pairer();
		}
	}
}