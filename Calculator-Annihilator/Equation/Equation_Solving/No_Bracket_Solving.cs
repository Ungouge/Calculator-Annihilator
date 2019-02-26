using System;

namespace Calculator_Annihilator
{
	partial class Equation
	{
        /// <summary>
        /// Solves given equation elements returns solved number as result.
        /// </summary>
        /// <param name="elements">Equation elements sorce list.</param>
        /// <exception cref="EquationIsEmptyException">Thrown when solving equation after been solved is left empty.</exception>
        /// <exception cref="EquationNotSolvedProperlyException">Thrown when solving equation after been solved is not composed of one number element.</exception>
        private Number No_Bracket_Solver(Equation_Elements elements )
		{
			foreach (IOperand[] operand_Level in Order_Of_Operations.Operands)
			{
				for (int operand_index = 0; operand_index < elements.Count; operand_index++)
				{
					if (elements[operand_index] is IOperand Equation_Operand)
					{
						foreach (IOperand operand_of_Level in operand_Level)
						{
							if (operand_of_Level == Equation_Operand)
							{
								INumber First_Number = (INumber)elements[operand_index - 1];
								INumber Seccond_Number = (INumber)elements[operand_index + 1];

								INumber Result_Number = _Calc.Operand_Selector(Equation_Operand, First_Number, Seccond_Number);

								Exchange_Solved_to_Simple_Calculated_Value(elements, operand_index, Result_Number);
								operand_index --;
							}
						}
					}
				}
			}

            if (elements.Count < 1)
                throw new EquationIsEmptyException();
            else if (elements.Count == 1 && elements[0] is Number Result)
				return Result;
			else
				throw new EquationNotSolvedProperlyException(elements.Recreate_Equation()); 
		}
	}
}
