using System;
using Common_Library;

namespace Calculator_Annihilator
{
	partial class Equation //Sack for values
	{
		public string the_Equation;

		Bracket_Pair Bracket_Map_Root = new Bracket_Pair();

		private Numeral_System _Numerical_System;

		private Parser _Parser;

		private Calc _Calc = new Calc();

		protected Equation_Elements Element_Colection = new Equation_Elements();

		public Number Solved_Value;
	}
}
