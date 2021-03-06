﻿using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
	partial class Equation //Sack for values
	{
		private readonly string the_Equation;

		Bracket_Pair Bracket_Map_Root = new Bracket_Pair();

		private readonly Numeral_System _Numerical_System;

        private readonly Parser _Parser;

        private readonly Calculator _Calculator = new Calculator();

		protected Equation_Elements Element_Colection = new Equation_Elements();

        private bool is_Solved = false;

        private Number _Solved_Number;

        public Number Solved_Number
        {
            get
            {
                Solve();

                return _Solved_Number;
            }
            set
            {
                _Solved_Number = value;
            }
        }

        public double Solved_Value
        {
            get
            {
                return Solved_Number.Value;
            }
        }

        public override string ToString()
        {
            return _Solved_Number.ToString();
        }
    }
}
