using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		// returns -1 when equation is too long
		// returns 0 when empty
		// reurns number between 1 and 3 when equation is single or part of single equation
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
