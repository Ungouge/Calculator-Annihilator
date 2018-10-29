﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		public void Equation_Solving()
		{
			No_Bracket_Solving(Elements_Colection.GetRange(0,Elements_Colection.Count));
			solved = true;
		}

		public double Solved_Value
		{
			get
			{
				if (solved == false)
					No_Bracket_Solving(Elements_Colection.GetRange(0, Elements_Colection.Count));

				return ( Elements_Colection[0] is INumber number) ? number.Value : 0 ; // xyz
			}
		}
	}
}

