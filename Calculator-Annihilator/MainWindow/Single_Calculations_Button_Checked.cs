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

namespace Calculator_Annihilator
{
	partial class MainWindow
	{
		/// <summary>
		/// Switches calculator to single calculation mode.
		/// </summary>
		private void Single_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
			Complex_To_Single();

			Disable_Complex_Buttons();
		}

		/// <summary>
		/// Take text from workspace and converts it as it would be inserted in single calculation mode.
		/// </summary>
		private void Complex_To_Single()
		{
			Current_Complex_Equation = new Equation(WorkSpace.Text, Current_Numerical_System);

			sbyte length_Of_Single_Equation = Current_Complex_Equation.Is_Equation_Single_byte_Long();

			switch (length_Of_Single_Equation)
			{
				case 0:
					Empty_WorkSpace_ToSingle();
					break;
				case 1:
					Only_Number_In_WorkSPace_To_single(Current_Complex_Equation.To_Single_First_Number);
					break;
				case 2:
					Number_And_operand_In_WorkSpace_To_Single
						(Current_Complex_Equation.To_Single_First_Number, Current_Complex_Equation.To_Single_Sign);
					break;
				case 3:
					Whole_Single_Equation_In_WorkSpace
						(Current_Complex_Equation.To_Single_First_Number, Current_Complex_Equation.To_Single_Sign,
							Current_Complex_Equation.To_Single_Seccond_Number);
					break;
				case 4:
					Complex_Equation_To_Solve_In_WorsSpace();
					break;
			}
		}

		/// <summary>
		/// Switching calculator to single calculation mode while in workspace is complex equation.
		/// </summary>
		private void Complex_Equation_To_Solve_In_WorsSpace()
		{
			Current_Complex_Equation.Solver();
			Reset_ResultSpace_Text(Current_Complex_Equation.Solved_Value.ToString());

			Clear_WorkSpace();
		}

		/// <summary>
		/// Switching calculator to single calculation mode while in workspace is whole single equation.
		/// </summary>
		private void Whole_Single_Equation_In_WorkSpace(double number1, char operand_Sign, double number2)
		{
			no_First_Number_In_Equation_Single = false;
			First_Number_In_Equation_Single = number1;

			Reset_ResultSpace_Text(First_Number_In_Equation_Single.ToString());

			no_operand_Sign_Single = true;
			operand_Sign_Single = operand_Sign;

			Insert_To_ResultSpace(operand_Sign_Single.ToString());

			Reset_WorkSpace_Text(number2.ToString());
		}

		/// <summary>
		/// Switching calculator to single calculation mode while in workspace is number and operator.
		/// </summary>
		private void Number_And_operand_In_WorkSpace_To_Single(double number1, char sign)
		{
			no_First_Number_In_Equation_Single = false;
			First_Number_In_Equation_Single = number1;

			Reset_ResultSpace_Text(First_Number_In_Equation_Single.ToString());

			no_operand_Sign_Single = true;
			operand_Sign_Single = sign;

			Insert_To_ResultSpace(operand_Sign_Single.ToString());

			Clear_WorkSpace();
		}

		/// <summary>
		/// Switching calculator to single calculation mode while in workspace is only one number.
		/// </summary>
		private void Only_Number_In_WorkSPace_To_single(double number1)
		{
			First_Number_In_Equation_Single = number1;
			no_First_Number_In_Equation_Single = false;

			Reset_ResultSpace_Text(First_Number_In_Equation_Single.ToString());

			Clear_WorkSpace();
		}

		/// <summary>
		/// Switching calculator to single calculation mode while in workspace is empty.
		/// </summary>
		private void Empty_WorkSpace_ToSingle()
		{
			Clear_ResultSpace();
			Clear_WorkSpace();

			no_operand_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;
		}

		/// <summary>
		/// Dissables buttons that have no use in single calculations.
		/// </summary>
		private void Disable_Complex_Buttons()
		{
			Button_Open_Bracket.IsEnabled = false;
			Button_Close_Bracket.IsEnabled = false;
		}
	}
}
