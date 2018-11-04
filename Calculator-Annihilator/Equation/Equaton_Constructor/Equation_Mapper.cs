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
		private void Equation_Mapper()
		{
			Bracket_Pairer();
			Equal_Number_Of_Brackets2();
		}

		private void Bracket_Pairer()
		{
			foreach (IElement bracket_Candidate in Elements_Colection)
			{
				if (bracket_Candidate is Open_Bracket OB && OB.Pair == null)
					Search_for_Close_Bracket(OB);

				if (bracket_Candidate is Close_Bracket CB && CB.Pair == null)
					Search_for_Open_Bracket(CB);
			}
		}

		private void Search_for_Close_Bracket(Open_Bracket OB)
		{
			int bracket_Index = Elements_Colection.IndexOf(OB);
			int bracket_Level = 0;

			for (int i = bracket_Index; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is Open_Bracket)
					bracket_Level++;

				if (Elements_Colection[i] is Close_Bracket CB)
					if (--bracket_Level == 0) {
						Bracket.Pair_brackets(OB, CB);
						return;
					}
			}
		}

		private void Search_for_Open_Bracket(Close_Bracket CB)
		{
			int bracket_Index = Elements_Colection.IndexOf(CB);
			int bracket_Level = 0;

			for (int i = bracket_Index; i >= 0; i--)
			{
				if (Elements_Colection[i] is Open_Bracket OB)
					if (++bracket_Level == 0) {
						Bracket.Pair_brackets(OB, CB);
						return;
					}

				if (Elements_Colection[i] is Close_Bracket)
					bracket_Level--;
			}
		}
		
		private void Equal_Number_Of_Brackets2()
		{
			for (int i = 0; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is IBracket_Pair BP && BP.Pair == null)
				{
					if (BP is Open_Bracket OB)
					{
						Close_Bracket new_CB = new Close_Bracket();
						Elements_Colection.Add(new_CB);
						Bracket.Pair_brackets(OB, new_CB);
					}
					else if (BP is Close_Bracket CB )
					{
						Open_Bracket new_OB = new Open_Bracket();
						Elements_Colection.Insert(0, new_OB);
						Bracket.Pair_brackets(new_OB, CB);
					}
				}
			}
		}
	}
}
