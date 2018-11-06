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
			public Bracket_Pair Root_Bracket_Pair = null;
			public List<Bracket_Pair> Inner_Brackets;

			static public int y =0;
			public int x;

			public Bracket_Pair(Open_Bracket OB, Close_Bracket CB, Bracket_Pair RBP)
			{
				_Open_Bracket = OB;
				_Close_Bracket = CB;
				Root_Bracket_Pair = RBP;
				x = y++;

				_Open_Bracket.Pair = this;
				_Close_Bracket.Pair  = this;

				Inner_Brackets = new List<Bracket_Pair>();
				if (Root_Bracket_Pair != null)
					Root_Bracket_Pair.Inner_Brackets.Add(this);
			}

		}
	}
}
