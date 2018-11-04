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
		private void Single_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
			Complex_To_Single();

			Disable_Complex_Buttons();
		}

		private void Complex_To_Single()
		{
			Equation _Equation = new Equation(WorkSpace.Text, Current_Numerical_System);

			sbyte length_Of_Single_Equation = _Equation.Is_Equation_Single_byte_Long();

			switch (length_Of_Single_Equation)
			{
				case 0:
					Empty_WorkSpace_ToSingle();
					break;
				case 1:
					Only_Number_In_WorkSPace_To_single(_Equation.To_Single_First_Number);
					break;
				case 2:
					Number_And_operand_In_WorkSpace_To_Single(_Equation.To_Single_First_Number, _Equation.To_Single_Sign);
					break;
				case 3:
					Whole_Single_Equation_In_WorkSpace(_Equation.To_Single_First_Number, _Equation.To_Single_Sign, _Equation.To_Single_Seccond_Number);
					break;
				case 4:
					Complex_Equation_To_Solve_In_WorsSpace(_Equation);
					break;
			}
		}

		private void Complex_Equation_To_Solve_In_WorsSpace(Equation _Equation)
		{
			_Equation.Solver();
			Reset_ResultSpace_Text(_Equation.Solved_Value.ToString());

			Clear_WorkSpace();
		}

		private void Whole_Single_Equation_In_WorkSpace(double number1, char sign, double number2)
		{
			no_First_Number_In_Equation_Single = false;
			First_Number_In_Equation_Single = number1;

			Reset_ResultSpace_Text(First_Number_In_Equation_Single.ToString());

			no_operand_Sign_Single = true;
			operand_Sign_Single = sign;

			Insert_To_ResultSpace(operand_Sign_Single.ToString());

			Reset_WorkSpace_Text(number2.ToString());
		}

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

		private void Only_Number_In_WorkSPace_To_single(double number1)
		{
			First_Number_In_Equation_Single = number1;
			no_First_Number_In_Equation_Single = false;

			Reset_ResultSpace_Text(First_Number_In_Equation_Single.ToString());

			Clear_WorkSpace();
		}

		private void Empty_WorkSpace_ToSingle()
		{
			Clear_ResultSpace();
			Clear_WorkSpace();

			no_operand_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;
		}

		private void Disable_Complex_Buttons()
		{
			Button_Open_Bracket.IsEnabled = false;
			Button_Close_Bracket.IsEnabled = false;
		}

		private void Complex_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
			string newWorkSpaceText = "";

			if (no_First_Number_In_Equation_Single == false)
				newWorkSpaceText += First_Number_In_Equation_Single.ToString();

			if (no_operand_Sign_Single == false)
				newWorkSpaceText += Operand_Sign_Single.ToString();

			newWorkSpaceText += WorkSpace.Text;

			Reset_WorkSpace_Text(newWorkSpaceText);

			no_operand_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;

			Enable_Complex_Buttons();
		}

		private void Enable_Complex_Buttons()
		{
			Button_Open_Bracket.IsEnabled = true;
			Button_Close_Bracket.IsEnabled = true;
		}
	}
}
