using System;
using System.Collections.Generic;
using System.Windows;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		/// <summary>
		/// Recreats string of equation after correcting mistakes.
		/// </summary>
		public string Recreate_Equation()
		{
			string recreated_Equation = "";

			/*for (int i = 0; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is IElement_ToString String_Element)
				{
					recreated_Equation += String_Element.ToString();
				}
			}*/
			//  xyz: experimentally.
			foreach (IElement_ToString String_Element in Element_Colection)
			{
				recreated_Equation += String_Element.ToString();
			}

			return recreated_Equation;
		}

	}
}
