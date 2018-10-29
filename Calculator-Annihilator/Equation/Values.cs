using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		public string the_Equation;

		private Numerical_System _Numerical_System;

		private Parser _Parser = new Parser();
		private Calc _Calc = new Calc();

		private Equation_Elements Elements_Colection = new Equation_Elements();

		private bool Does_Solved = false;

		public double Solved_Value
		{
			get
			{
				if (Does_Solved == false)
					Solver();

				return Solved_Value;
			}
			private set
			{
				Solved_Value = value;
			}
		}
	}
}
