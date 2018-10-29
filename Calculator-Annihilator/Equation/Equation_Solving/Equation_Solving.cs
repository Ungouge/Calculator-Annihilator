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

			INumber Result_Number = No_Bracket_Solver (new Equation_Elements(Elements_Colection.GetRange ( 0 ,Elements_Colection.Count)), );

			Exchange_Solved_Range_to_Calculated_Value(Elements_Colection, 0, Elements_Colection.Count, Result_Number);
			solved = true;
		}

		public double Solved_Value
		{
			get
			{
				if (solved == false)
					No_Bracket_Solver(Elements_Colection.GetRange(0, Elements_Colection.Count));

				return ( Elements_Colection[0] is INumber number) ? number.Value : 0 ; // xyz
			}
		}
	}
}

