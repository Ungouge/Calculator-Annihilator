using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation //Sack for values
	{
		public string the_Equation;

		Bracket_Pair Bracket_Map_Root = new Bracket_Pair();

		private Numeral_System _Numerical_System;

		private Parser _Parser = new Parser();
		private Calc _Calc = new Calc();

		private Equation_Elements Element_Colection = new Equation_Elements();

		//private bool Does_Solved = false;

		public Number Solved_Value // xyz does needed to restor
		/*{
			get
			{
				if (Does_Solved == false)
					Solver();

				return Solved_Value;
			}
			set
			{
				Solved_Value = value;
			}
		}*/;
	}
}
