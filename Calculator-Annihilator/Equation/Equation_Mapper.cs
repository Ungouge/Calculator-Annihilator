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
			Equal_Number_Of_Brackets();
			Bracket_Pairer();
		}

		private void Bracket_Pairer()
		{
			foreach (IElement bracket_Candidate in Elements_Colection)
			{
				if (bracket_Candidate is Open_Bracket OB && OB.Pair == null)
					Search_for_Close_Bracket(OB);

				if (bracket_Candidate is Close_Bracket CB && CB.Pair == null)
					Search_for_Open_Bracket(Elements_Colection.IndexOf(CB));
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
					if (--bracket_Level == 0)
						Bracket.Pair_brackets(OB, CB);
			}
		}

		private void Search_for_Open_Bracket(int bracket_Index)
		{
			throw new NotImplementedException();
		}

		private void Equal_Number_Of_Brackets()
		{
			int bracket_Level = 0;
			
			foreach (Element br in Elements_Colection)
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
					Open_Bracket.Emergent_Addition_of_Open_Bracket(this);
					bracket_Level++;
					//MessageBox.Show("(");
				}
				else if (bracket_Level > 0)
				{
					Elements_Colection.Add( new Close_Bracket());
					bracket_Level--;
					//MessageBox.Show(")");
				}
			}
		}
	}
}
