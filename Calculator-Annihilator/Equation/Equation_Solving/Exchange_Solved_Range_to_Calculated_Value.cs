using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private void Exchange_Solved_Range_to_Calculated_Value(List<IElement> elements, int operand_index, Number Result_Number)
		{
			elements.Insert(operand_index - 1, Result_Number);
			elements.RemoveRange(operand_index, 3);
		}
	}
}
