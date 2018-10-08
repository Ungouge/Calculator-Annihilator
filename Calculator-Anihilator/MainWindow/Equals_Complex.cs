using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		private double Equals_Complex(string equation)
		{
			Equation eq = new Equation(equation);
			return 0e0; //Equals_No_Brackets(equation);
		}

	//	private double Equals_No_Brackets (string equation)
	//	{
	//		int[] action_Sign_Level = new int[equation.Length];
	//		for (int i = 0; i < action_Sign_Level.Length; i++)
	//			action_Sign_Level[i] = -1;

	//		List<int> operation_Sign_Position = new List<int>();

	//		for (int i = 0; i < equation.Length; i++)
	//		{
	//			for (int j = 0; j < action_Sings.Length; j++)
	//			{
	//				for (int k = 0; k < action_Sings[j].Length; k++)
	//				{
	//					if (action_Sings[j][k] == equation[i])
	//						action_Sign_Level[i] = j;
	//				}
	//			}	
	//		}



	//		for (int i = 0; i < action_Sings.Length; i++)
	//		{
	//			for (int j = 0; j < action_Sign_Level.Length; j++)
	//			{
	//				int previous_Sign = -1;
	//				int next_Sign = equation.Length;

	//				for (int k = i-1; k > 0; k--)
	//					if (action_Sign_Level[k]>=0)
	//					{
	//						previous_Sign = k;
	//						break;
	//					}

	//				for (int k = i +1 ; k < action_Sings.Length; k++)
	//					if (action_Sign_Level[k] > 0)
	//					{
	//						previous_Sign = k;
	//						break;
	//					}


	//			}
	//		}
	//		return 0e0;
	//	}

	//	private double Equals_Bracket(string equation)
	//	{
	//		List<int> open_Bracket_Position = new List<int>();
	//		List<int> close_Bracket_Position = new List<int>();

	//		int bracket_Level = 0;

	//		for (int i = 0; i > equation.Length; i++)
	//		{
	//			if (equation[i] == '(')
	//			{
	//				open_Bracket_Position.Add(i);
	//				bracket_Level++;
	//			}


	//			if (equation[i] == ')')
	//			{
	//				close_Bracket_Position.Add(i);
	//				bracket_Level--;
	//			}
	//		}

	//		while (bracket_Level != 0)
	//		{
	//			if (bracket_Level < 0)
	//			{
	//				open_Bracket_Position.Add(0);
	//				bracket_Level++;
	//			}

	//			if (bracket_Level > 0)
	//			{
	//				close_Bracket_Position.Add(equation.Length);
	//				bracket_Level--;
	//			}
	//		}


	//		/*for( int = 0; i > open_Bracket_Position.Length; i++) //bracket check
	//		{
	//			if(open_Bracket_Position[i] < close_Bracket_Position[i])
	//		}*/

	//		//bracket pairing
			
	//		int[] open_Bracket_Position_Arr = open_Bracket_Position.ToArray();
	//		int[] close_Bracket_Position_Arr = close_Bracket_Position.ToArray();
			

	//		int[] close_open_Pairs = new int[close_Bracket_Position.Count];

	//		for (int cp = 0; cp < close_Bracket_Position.Count; cp++)
	//		{
	//			for (int op = 0; op < length; op++)
	//			{
	//				if (open_Bracket_Position[op] > close_Bracket_Position[cp])
	//				{
	//					close_Bracket_Position_Arr.Skip(0)
	//				}

	//			}
	//		}
	//		do
	//		{

	//		} while (open_Bracket_Position[op] > close_Bracket_Position[cp]);
	//		return 0e0;
	//	}


	//	private double Equals_Operators(string equation, int order)
	//	{
	//	}

	//	private double Equals_Ordered_By_Operations(int order, string equation)
	//	{
	//		/*List<int> Operation_signs_List = new List<int>();

	//		for (int i = 0; i < equation.Length; i++)
	//		{
	//			if (equation[i] == ///////////////
	//		}*/
	//		return 0e0;
	//	}
	//}

	///*class In_Brackets
	//{
	//	public int[] open_Bracket_Arr;
	//	public int[] close_Bracket_Arr;
	//	public int[] bracket_Pairs_Arr;

	//	public string equation;

	//	public In_Brackets(string eq, int[] ob, int[] cb)
	//	{
	//		equation = eq;
	//		open_Bracket_Arr = ob;
	//		close_Bracket_Arr = cb;
	//	}

	//	public void pair_Brackets()
	//	{
	//		for (int cb = 0; cb < close_Bracket_Arr.Length; cb++)
	//		{
	//			for (int op = 0; op < open_Bracket_Arr.Length; op++)
	//			{
	//				if (close_Bracket_Arr[cb] > open_Bracket_Arr[op])

	//			}
	//		}

	//	*/}
	
	}
}
