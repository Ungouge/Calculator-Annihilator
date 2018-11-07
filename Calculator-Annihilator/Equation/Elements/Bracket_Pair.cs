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
			public Open_Bracket _Open_Bracket { get; private set; }
			public Close_Bracket _Close_Bracket { get; private set; }
			public Bracket_Pair Root_Bracket_Pair;
			public List<Bracket_Pair> Inner_Brackets;

			public Bracket_Pair() // only for root of bracket map
			{
				Inner_Brackets = new List<Bracket_Pair>();
				Root_Bracket_Pair = null;
			}

			public Bracket_Pair(Open_Bracket OB, Close_Bracket CB, Bracket_Pair RBP)
			{
				_Open_Bracket = OB;
				_Close_Bracket = CB;

				_Open_Bracket.Pair = this;
				_Close_Bracket.Pair  = this;

				Root_Bracket_Pair = RBP;

				Inner_Brackets = new List<Bracket_Pair>();
				if (Root_Bracket_Pair != null)
					Root_Bracket_Pair.Inner_Brackets.Add(this);
			}
		}
	}
}
