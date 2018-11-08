using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private Number No_Bracket_Solver(Equation_Elements elements )
		{
			foreach (char[] operand_Level in Signs_Lib.operand_Sings)
			{
				for (int operand_index = 0; operand_index < elements.Count; operand_index++)
				{
					if (elements[operand_index] is IOperand Equation_Operand)
					{
						foreach (char operand_of_Level in operand_Level)
						{
							if (operand_of_Level == Equation_Operand.Sign)
							{
								Number First_Number = (elements[operand_index - 1] is Number fn) ? fn : new Number(1); // xyz: propably to remove ?!
								Number Seccond_Number = (elements[operand_index + 1] is Number sn) ? sn : new Number(1);

								Number Result_Number = Simple_Solve(First_Number, Equation_Operand, Seccond_Number);
								Exchange_Solved_to_Simple_Calculated_Value(elements, operand_index, Result_Number);
								operand_index --;
							}
						}
					}
				}
			}
			if (elements.Count == 1 && elements[0] is Number Result) // hopefully temporery
				return Result;
			else
				return new Number(0);
				//throw new EquationNotSolvedProperlyException(); // don't forget to remove exception if it no longer needed
		}

		// return new object Number as result of operation 
		private Number Simple_Solve (INumber first_Number, IOperand operand, INumber seccond_Number)
		{
			return _Calc.Operand_Selector(operand, first_Number, seccond_Number);
		}
	}
}
