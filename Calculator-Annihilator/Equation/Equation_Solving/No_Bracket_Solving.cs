using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private IElement equation_Operand;

		private void No_Bracket_Solving(List<IElement> elements )
		{
			foreach (char[] operand_Level in Signs_Lib.operand_Sings)
			{
				foreach (Element Equation_Element in elements)
				{
					if (Equation_Element is IOperand Eqation_Operand)
					{
						foreach (char operand_of_Level in operand_Level)
						{
							if (operand_of_Level == Eqation_Operand.Sign)
							{
								int operand_index = elements.IndexOf(equation_Operand);

								Number First_Number = (elements[operand_index - 1] is Number fn) ? fn : new Number(0); // xyz: propably to remove ?!
								Number Seccond_Number = (elements[operand_index + 1] is Number sn) ? sn : new Number(0);

								Number Result_Number = Simple_Solve(First_Number, Eqation_Operand, Seccond_Number);

								Execute_Simple_Solve_in_List(elements, operand_index, Result_Number);
							}
						}
					}
				}
			}
		}

		private void Execute_Simple_Solve_in_List(List<IElement> elements, int operand_index, Number Result_Number)
		{
			elements.Insert(operand_index - 1, Result_Number);
			elements.RemoveRange(operand_index, 3);
		}

		// return new object Number as result of operation 
		private Number Simple_Solve (INumber first_Number, IOperand operand, INumber seccond_Number)
		{
			double value = Calc.Operand_Selector(operand.Sign, first_Number.Value, seccond_Number.Value);

			return new Number(value);
		}

		/*private void Solve_Current_Operand_Level(int begining, int end, int[] current_Level_Operands)
		{
			throw new NotImplementedException();
		}

		private int[] Enlist_Current_Operand_Level(int begining, int end, int level)
		{
			List<int> Current_Operand_Level_Position_List = new List<int>();

			for (int i = begining; i < end; i++)
				foreach (char operand in Signs_Lib.operand_Sings[level])
					if (Elements_Colection[i] is Operand equational_Operand)
						if (equational_Operand.sign == operand)
							Current_Operand_Level_Position_List.Add(i);

			return Current_Operand_Level_Position_List.ToArray();
		}*/
	}
}
