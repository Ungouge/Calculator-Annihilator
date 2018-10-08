using System;
using System.Collections.Generic;
using System.Windows;

namespace Calculator_Anihilator
{
	partial class Equation
	{
		string the_Equation;

		public Equation(string eq)
		{
			try
			{
				the_Equation = eq;
				Element_Selector(eq);
				Equation_Mapper();

				MessageBox.Show(Recreate_Equation());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public string Recreate_Equation()
		{
			string recreated_Equation = "";

			for (int i = 0; i < Element.Elements_List.Count; i++)
			{
				if (Element.Elements_List[i] is IElementToString String_Element)
				{
					recreated_Equation += String_Element.ToString();
				}
			}

			return recreated_Equation;
		}

	}
}
