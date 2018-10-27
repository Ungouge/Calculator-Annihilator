using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
	public partial class Equation
	{
		public string the_Equation;

		Numerical_System numerical_System;


		Equation_Elements Elements_Colection = new Equation_Elements();


		private Parser parser = new Parser();

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

		public Equation(string eq, Numerical_System ns)
		{
			try
			{
				Reset();
				the_Equation = eq;
				numerical_System = ns;

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
