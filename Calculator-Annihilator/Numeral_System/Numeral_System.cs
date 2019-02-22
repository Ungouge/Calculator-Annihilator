using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
	/// <summary>
	/// Contains data of numeral systems based on encoded number:
	///  <para>from 2 to 60 for positional systems base on number,</para>
	/// 1 for bijective system, -2 negabinary system, balanced ternary system.
	/// </summary>
	/// <exception cref="NoSuchNumericalSystemException">Thrown when is given wrong code number of numeral system</exception>
	public partial class Numeral_System
	{
		public char[] System_Digits { get; private set; }
		public sbyte System_Type { get; private set;}

		/// <summary>
		/// Constructs new numeral system based on encoded number:
		/// <para>from 2 to 60 for positional systems base on number,</para>
		/// 1 for bijective system, -2 negabinary system, balanced ternary system.
		/// </summary>
		/// <param name="system_Base_Code">Base of new numeral system or encoded number for exotic numeral system</param>
		public Numeral_System(sbyte system_Base_Code)
		{
			List<char> System_Symbol = new List<char>();

			System_Type = system_Base_Code;

			if (system_Base_Code > 1 && system_Base_Code <= 64)
			{
				for (int i = 0; i < system_Base_Code; i++)
				{
					if (i < 10)
						System_Symbol.Add((Char)(i + 48));
					else if (i < 35)
						System_Symbol.Add((char)(i + 55));
					else
						System_Symbol.Add((char)(i + 62));
				}

				System_Digits = System_Symbol.ToArray();
			}
			else
			{
				switch (system_Base_Code)
				{
					case 1:
						System_Digits = Bijective_System();
						break;
					case -2:
						System_Digits = Negabinary_System();
						break;
					case -3:
						System_Digits = Balanced_ternary_System();
						break;
					default:
						throw new NoSuchNumericalSystemException();
				}
			}
		}

		private char[] Bijective_System()
		{
			return new char[] { '1'};
		}

		private char[] Negabinary_System()
		{
			return new char[] { '0', '1' };
		}

		private char[] Balanced_ternary_System()
		{
			return new char[] { '-', '0', '+' };
		}

		///there are C# implenetation in wikepedia of some systems :)
	}
}
