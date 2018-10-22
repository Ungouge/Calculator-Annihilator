using System;
using System.Collections.Generic;
using System.Windows;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		public double Result
		{
			get
			{
				string str = "";
				foreach (IElement element in Elements_Colection)
				{
					if (element is Number nmb)
						str += nmb.ToString();
				}
				return Double.Parse(str);
			}
		}

		public string Recreate_Equation()
		{
			string recreated_Equation = "";

			for (int i = 0; i < Elements_Colection.Count; i++)
			{
				if (Elements_Colection[i] is IElement_ToString String_Element)
				{
					recreated_Equation += String_Element.ToString();
				}
			}

			return recreated_Equation;
		}

	}
}
