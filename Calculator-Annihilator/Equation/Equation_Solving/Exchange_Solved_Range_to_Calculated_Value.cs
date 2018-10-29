using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private void Execute_Simple_Solve_in_List(List<IElement> elements, int operand_index, Number Result_Number)
		{
			elements.Insert(operand_index - 1, Result_Number);
			elements.RemoveRange(operand_index, 3);
		}
	}
}
