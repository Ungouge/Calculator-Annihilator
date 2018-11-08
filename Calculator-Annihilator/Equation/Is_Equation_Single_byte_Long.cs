using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		/// <summary>
		/// Checks is current simple calculation data may be convert to complex calculation while switching methods.
		/// </summary>
		/// <return>
		/// Returns number of elements to convert (1-3), 4 when data is too long, -1 when something is wrong or 0 when data are empty.
		/// </return>
		public sbyte Is_Equation_Single_byte_Long()
		{
			if (Elements_Colection.Count > 3)
				return 4;
			else if (Elements_Colection.Count == 0)
				return 0;
			else
			{
				if (Elements_Colection[0] is Number)
				{
					if (Elements_Colection.Count > 1)
					{
						if (Elements_Colection[1] is IOperand)
						{
							if (Elements_Colection.Count == 3)
							{
								if (Elements_Colection[2] is Number)
									return 3;
								else
									return -1;
							}
							else
								return 2;
						}
						else
							return -1;
					}
					else
						return 1;
				}
				else
					return -1;
			}
		}

		/// <summary>
		/// Returns first number of single equation.
		/// </summary>
		public double To_Single_First_Number
		{
			get
			{
				if (Elements_Colection[0] is Number number)
					return number.Value;
				else
					return 0e0;
			}
		}

		/// <summary>
		/// Returns operand of single equation.
		/// </summary>
		public char To_Single_Sign
		{
			get
			{
				if (Elements_Colection[1] is IOperand _Operand)
					return _Operand.ToString()[0];
				else
					return default(char);
			}
		}

		/// <summary>
		/// Returns seccond number of single equation.
		/// </summary>
		public double To_Single_Seccond_Number
		{
			get
			{
				if (Elements_Colection[2] is Number number)
					return number.Value;
				else
					return 0e0;
			}
		}
	}
}
