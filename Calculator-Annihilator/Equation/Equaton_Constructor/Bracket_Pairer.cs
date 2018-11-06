using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private void Bracket_Pairer()
		{
			Bracket_Pair Current_Externall_Bracket = null;

			for (int i = 0; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is Open_Bracket OB && OB.Pair == null) // && possibly obsolite
					Current_Externall_Bracket = Search_for_Close_Bracket(OB, Current_Externall_Bracket);

				if (Elements_Colection[i] is Close_Bracket CB)
				{
					if (CB.Pair == null)
						Add_Open_Bracket(CB, Current_Externall_Bracket);
					else
						Current_Externall_Bracket = CB.Pair.Root_Bracket_Pair;
				}
			}
		}

		private Bracket_Pair Search_for_Close_Bracket(Open_Bracket OB, Bracket_Pair Root_Bracket_Pair)
		{
			int bracket_Index = Elements_Colection.IndexOf(OB);
			int bracket_Level = 0;

			for (int i = bracket_Index; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is Open_Bracket)
					bracket_Level++;

				if (Elements_Colection[i] is Close_Bracket CB)
					if (--bracket_Level == 0)
						return new Bracket_Pair(OB, CB, Root_Bracket_Pair);
			}

			while (--bracket_Level > 0)
				Elements_Colection.Add(new Close_Bracket());

			return Add_Close_Bracket(OB, Root_Bracket_Pair);
		}

		private Bracket_Pair Add_Close_Bracket(Open_Bracket OB, Bracket_Pair Root_Bracket_Pair)
		{
			Close_Bracket new_CB = new Close_Bracket();
			Elements_Colection.Add(new_CB);
			return new Bracket_Pair(OB, new_CB, Root_Bracket_Pair);
		}

		private void Add_Open_Bracket(Close_Bracket CB, Bracket_Pair Root_Bracket_Pair)
		{
			Open_Bracket new_OB = new Open_Bracket();
			Elements_Colection.Insert(0, new_OB);
			Bracket_Pair bracket_Pair = new Bracket_Pair(new_OB, CB, Root_Bracket_Pair);
		}
	}
}
