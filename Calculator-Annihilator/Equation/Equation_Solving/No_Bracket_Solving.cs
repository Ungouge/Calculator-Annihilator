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
		/// Solves given equation elements returns solved number as result.
		/// </summary>
		/// <param name="elements">Equation elements sorce list.</param>
		/// <returns></returns>
		private Number No_Bracket_Solver(Equation_Elements elements )
		{
			foreach (IOperand[] operand_Level in Signs_Lib.Operands)
			{
				for (int operand_index = 0; operand_index < elements.Count; operand_index++)
				{
					if (elements[operand_index] is IOperand Equation_Operand)
					{
						foreach (IOperand operand_of_Level in operand_Level)
						{
							if (operand_of_Level == Equation_Operand)
							{
								Number First_Number = (elements[operand_index - 1] is Number fn) ? fn : new Number(1); // xyz: propably to remove ?!
								Number Seccond_Number = (elements[operand_index + 1] is Number sn) ? sn : new Number(1);

								Number Result_Number = _Calc.Operand_Selector(Equation_Operand, First_Number, Seccond_Number);
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
	}
}
