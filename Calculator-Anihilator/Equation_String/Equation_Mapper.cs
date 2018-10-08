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

namespace Calculator_Anihilator
{
	partial class Equation
	{
		private void Equation_Mapper()
		{
			Equal_Number_Of_Brackets();

			Bracket_Pairer();

		}

		private void Bracket_Pairer()
		{
			foreach (Bracket bracket in Bracket.bracket_List)
			{
				if (bracket is Open_Bracket OB && OB.Pair == null)
					Search_for_Close_Bracket(OB);

				if (bracket is Close_Bracket CB && CB.Pair == null)
					Search_for_Open_Bracket(Bracket.bracket_List.IndexOf(CB));
			}
		}

		private void Search_for_Close_Bracket(Open_Bracket OB)
		{
			int bracket_Index = Bracket.bracket_List.IndexOf(OB);
			int bracket_Level = 0;

			for (int i = bracket_Index; i < Bracket.bracket_List.Count; i++)
			{
				if (Bracket.bracket_List[i] is Open_Bracket)
					bracket_Level++;

				if (Bracket.bracket_List[i] is Close_Bracket CB)
					if (--bracket_Level == 0)
						Bracket.Pair_brackets(OB, CB);
			}
		}

		private void Search_for_Open_Bracket(int bracket_Index)
		{
			throw new NotImplementedException();
		}

		private static void Equal_Number_Of_Brackets()
		{
			int bracket_Level = 0;
			foreach (Bracket br in Bracket.bracket_List)
			{
				if (br is Open_Bracket)
					bracket_Level++;
				else if (br is Close_Bracket)
					bracket_Level--;
			}

			while( bracket_Level != 0)
			{
				if (bracket_Level < 0)
				{
					Open_Bracket.Emergent_Addition_of_Open_Bracket();
					bracket_Level++;
					MessageBox.Show("(");
				}
				else if (bracket_Level > 0)
				{
					new Close_Bracket();
					bracket_Level--;
					MessageBox.Show(")");
				}
			}
		}
	}
}
