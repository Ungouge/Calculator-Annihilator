using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private void Exchange_Solved_to_Simple_Calculated_Value(Equation_Elements elements, int operand_index, Number Result_Number)
		{
			elements.ReplaceRange(operand_index - 1, 3, Result_Number);
		}

		private void Exchange_Solved_Range_to_Calculated_Value(Equation_Elements elements, int operand_index, int count, Number Result_Number)
		{
			elements.ReplaceRange(operand_index, count, Result_Number);
		}
	}
}
