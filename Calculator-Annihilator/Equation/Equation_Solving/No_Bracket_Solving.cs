using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private INumber No_Bracket_Solver(List<IElement> elements )
		{
			foreach (char[] operand_Level in Signs_Lib.operand_Sings)
			{
				foreach (Element Equation_Element in elements)
				{
					if (Equation_Element is IOperand Equation_Operand)
					{
						foreach (char operand_of_Level in operand_Level)
						{
							if (operand_of_Level == Equation_Operand.Sign)
							{
								int operand_index = elements.IndexOf((IElement) Equation_Operand);

								Number First_Number = (elements[operand_index - 1] is Number fn) ? fn : new Number(0); // xyz: propably to remove ?!
								Number Seccond_Number = (elements[operand_index + 1] is Number sn) ? sn : new Number(0);

								Number Result_Number = Simple_Solve(First_Number, Equation_Operand, Seccond_Number);

								Exchange_Solved_Range_to_Calculated_Value(elements, operand_index, Result_Number);
							}
						}
					}
				}
			}
			if (elements.Count == 1 && elements[0] is INumber Result)
				return	Result;
			else
				throw 
		}

		// return new object Number as result of operation 
		private Number Simple_Solve (INumber first_Number, IOperand operand, INumber seccond_Number)
		{
			double value = calc.Operand_Selector(operand.Sign, first_Number.Value, seccond_Number.Value);

			return new Number(value);
		}
	}
}
