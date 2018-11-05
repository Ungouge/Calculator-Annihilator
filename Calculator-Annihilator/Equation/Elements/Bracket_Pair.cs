using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		public class Bracket_Pair
		{
			Open_Bracket _Open_Bracket;
			Close_Bracket _Close_Bracket;
			Bracket_Pair Root_Bracket_Pair = null;
			List<Bracket_Pair> Inner_Brackets;

			public Bracket_Pair(Open_Bracket OB, Close_Bracket CB)
			{
				_Open_Bracket = OB;
				_Close_Bracket = CB;

				_Open_Bracket.Pair = this;
				_Close_Bracket.Pair  = this;

				Inner_Brackets = new List<Bracket_Pair>();
			}

			public Bracket_Pair(Open_Bracket OB, Close_Bracket CB, Bracket_Pair RBP) : this( OB, CB)
			{
				Root_Bracket_Pair = RBP;
			}
		}
	}
}
