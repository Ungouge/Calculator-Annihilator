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
		public Equation ( string eq, Numerical_System ns )
		{
			try
			{
				the_Equation = eq;
				_Numerical_System = ns;

				Element_Selector(eq);
				Integrity_Check(Elements_Colection);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			Bracket_Pairer();
		}

		// xyz: to remove with unit test, with Pair.x
		public bool Check_Pairity()
		{
			bool doh = true;

			Stack<int> a = new Stack<int>();

			foreach (var item in Elements_Colection)
			{

				if (item is Open_Bracket OB)
				{
					a.Push(OB.Pair.x);
				}
				else if (item is Close_Bracket CB)
				{
					if (CB.Pair.x != a.Pop())
						doh = false;
				}
			}

			return doh;
		}
	}
}
