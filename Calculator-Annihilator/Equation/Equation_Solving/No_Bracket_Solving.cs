using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	partial class Equation
	{
		private void No_Bracket_Solving(int begining, int end)
		{
			int[] Current_Level_Operands;

			for (int i = 0; i < MainWindow.action_Sings.Length; i++)
			{
				Current_Level_Operands = Enlist_Current_Operand_Level(begining, end, i);
				Solve_Current_Operand_Level(begining, end, Current_Level_Operands);
			}

			/*foreach (char[] vs in MainWindow.action_Sings)
			{
				foreach (char operand in vs)
				{
					for (int i = begining; i < end; i++)
					{
						if (Element.Elements_List[i] is Operand equational_Operand)
						{
							if (equational_Operand.sign == operand)
							{

							}
						}
					}
				}

			}*/
		}

		private void Solve_Current_Operand_Level(int begining, int end, int[] current_Level_Operands)
		{
			throw new NotImplementedException();
		}

		private int[] Enlist_Current_Operand_Level(int begining, int end, int level)
		{
			List<int> Current_Operand_Level_Position_List = new List<int>();

			for (int i = begining; i < end; i++)
				foreach (char operand in MainWindow.action_Sings[level])
					if (Elements_Colection[i] is Operand equational_Operand)
						if (equational_Operand.sign == operand)
							Current_Operand_Level_Position_List.Add(i);

			return Current_Operand_Level_Position_List.ToArray();
		}
	}
}
