using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		string the_Equation;
		Equation_Elements Elements_Colection = new Equation_Elements();

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

		public Equation(string eq)
		{
			try
			{
				Reset();
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

		public Equation()// porzez podanie listy
		{
			;
		}
	}
}
