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
		/// <summary>
		/// Pairs brackets in equation, adds open brackets at the begining or close brackets at the end if there are missing.
		/// </summary>
		private void Bracket_Pairer()
		{
			Bracket_Pair Current_Externall_Bracket = Bracket_Map_Root;

			for (int i = 0; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is Open_Bracket OB && OB.Pair == null)
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

		/// <summary>
		/// Searches closing bracket for given open bracket in equation.
		/// </summary>
		/// <param name="Opening_Bracket"></param>
		/// <param name="Root_Bracket_Pair"></param>
		/// <returns></returns>
		private Bracket_Pair Search_for_Close_Bracket(Open_Bracket Opening_Bracket, Bracket_Pair Root_Bracket_Pair)
		{
			int bracket_Index = Elements_Colection.IndexOf(Opening_Bracket);
			int bracket_Level = 0;

			for (int i = bracket_Index; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is Open_Bracket)
					bracket_Level++;

				if (Elements_Colection[i] is Close_Bracket CB)
					if (--bracket_Level == 0)
						return new Bracket_Pair(Opening_Bracket, CB, Root_Bracket_Pair);
			}

			while (--bracket_Level > 0)
				Elements_Colection.Add(new Close_Bracket());

			return Add_Close_Bracket(Opening_Bracket, Root_Bracket_Pair);
		}

		/// <summary>
		/// Adds missing closing bracket at the end of equation if missing. 
		/// </summary>
		/// <param name="_Open_Bracket"></param>
		/// <param name="Root_Bracket_Pair"></param>
		/// <returns></returns>
		private Bracket_Pair Add_Close_Bracket(Open_Bracket _Open_Bracket, Bracket_Pair Root_Bracket_Pair)
		{
			Close_Bracket new_CB = new Close_Bracket();
			Elements_Colection.Add(new_CB);
			return new Bracket_Pair(_Open_Bracket, new_CB, Root_Bracket_Pair);
		}

		/// <summary>
		/// Adds missing copening bracket at the beging of equation if missing.
		/// </summary>
		/// <param name="Closing_Bracket"></param>
		/// <param name="Root_Bracket_Pair"></param>
		private void Add_Open_Bracket(Close_Bracket Closing_Bracket, Bracket_Pair Root_Bracket_Pair)
		{
			Open_Bracket new_OB = new Open_Bracket();
			Elements_Colection.Insert(0, new_OB);
			Bracket_Pair bracket_Pair = new Bracket_Pair(new_OB, Closing_Bracket, Root_Bracket_Pair);
		}
	}
}
