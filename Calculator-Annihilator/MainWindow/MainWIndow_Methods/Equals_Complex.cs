﻿using System;

namespace Calculator_Annihilator
{
	partial class MainWindow //Equals_Complex
	{
		/// <summary>
		/// Controlls action after pressing equals button when option for complex calculations is on.
		/// </summary>
		private void Equals_Complex(string equation)
		{
			Equation = new Equation(equation, Current_Numeral_System);
            Reset_ResultSpace_Text(Back_Parser.Parse_Back(Equation.Solved_Number));
		}
	}
}
