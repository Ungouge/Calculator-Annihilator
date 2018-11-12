using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		/// <summary>
		/// Solves whole equation and gives result to Solved_Value.
		/// </summary>
		public void Solver()
		{
			Number Result_Number = Inner_Brackets_Solver(Element_Colection, Bracket_Map_Root);

			Bracket_Map_Root = null;
			Solved_Value = Result_Number;
			Does_Solved = true;
		}
	}
}

