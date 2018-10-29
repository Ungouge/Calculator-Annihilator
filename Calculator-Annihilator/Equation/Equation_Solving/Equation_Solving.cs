using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		public void Solver()
		{
			// TBA Between_Brackets_Solver

			Number Result_Number = No_Bracket_Solver (new Equation_Elements(Elements_Colection.GetRange ( 0 ,Elements_Colection.Count - 1)));

			Exchange_Solved_Range_to_Calculated_Value(Elements_Colection, 0, Elements_Colection.Count - 1, Result_Number);

			if (Elements_Colection.Count == 1 && Elements_Colection[0] is Number Result) // hopefully temporery
			{
				Solved_Value = Result.Value;
				Does_Solved = true;
			}
			else
				throw new EquationNotSolvedProperlyException(); // don't forget to remove exception if it no longer needed
		}
	}
}

