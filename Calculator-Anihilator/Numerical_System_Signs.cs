using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	public class Numerical_System_Signs
	{
		public char[] System_Digits { get; private set; }
		public int System_Type { get; private set;}

		readonly Exception NoSuchNumericalSystem = null;

		public Numerical_System_Signs(int ns)
		{
			List<char> System_Symbol = new List<char>();

			System_Type = ns;

			if (ns > 1 && ns < 61)
			{
				for (int i = 0; i < ns; i++)
				{
					if (i < 10)
						System_Symbol.Add(Convert.ToChar(i));
					else if (i < 35)
						System_Symbol.Add((char)(i + 55));
					else
						System_Symbol.Add((char)(i + 62));
				}
			}
			else if (ns == 1)
			{
				System_Symbol.Add('1');
			}
			else if (ns == -2)
			{
				System_Symbol.Add('0');
				System_Symbol.Add('1');
			}
			else if (ns == -3)
			{
				System_Symbol.Add('+');
				System_Symbol.Add('0');
				System_Symbol.Add('-');
			}
			else
				throw NoSuchNumericalSystem;

			System_Digits = System_Symbol.ToArray();
		}
	}
}
