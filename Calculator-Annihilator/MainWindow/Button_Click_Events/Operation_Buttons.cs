using System;
using System.Windows;

namespace Calculator_Annihilator
{
	partial class MainWindow // Operation buttons sack
	{
		private void Button_PlusSign_Click(object sender, RoutedEventArgs e)
		{
			Operation_Button(new Addition());
		}

		private void Button_MinuSing_Click(object sender, RoutedEventArgs e)
		{
			Operation_Button(new Subtraction());
		}

        private void Button_MultiplicationSing_Click(object sender, RoutedEventArgs e)
        {
            Operation_Button(new Multiplication());
        }

        private void Button_DivisionSign_Click(object sender, RoutedEventArgs e)
		{
			Operation_Button(new Division());
		}

		/// <summary>
		/// Controls perfomance of equals button according to calculation options setup.
		/// </summary>
		private void Button_Equals_Click(object sender, RoutedEventArgs e)
		{
			if (Convert.ToBoolean(GUI_Dynamic_Parameters.Calculation_Method == Calculation_Method.Single))
			{
				Equals_Single();
			}
			else if (Convert.ToBoolean(GUI_Dynamic_Parameters.Calculation_Method == Calculation_Method.Complex))
			{
				Equals_Complex(WorkSpace.Text);
			}
		}

		private void Button_Open_Bracket_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('(');
		}

		private void Button_Close_Bracket_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace(')');
		}

		private void Button_CE_Click(object sender, RoutedEventArgs e)
		{
			BackSpace_WorkSpace();
		}

		/// <summary>
		/// Controls perfomance of clear button according to calculation options setup.
		/// </summary>
		private void Button_Clear_Click(object sender, RoutedEventArgs e)
		{
			Clear_WorkSpace();
			Clear_ResultSpace();

			if (Convert.ToBoolean(GUI_Dynamic_Parameters.Calculation_Method == Calculation_Method.Single))
			{
				no_operand_Sign_Single = true;
				no_First_Number_In_Equation_Single = true;
			}
			else if (Convert.ToBoolean(GUI_Dynamic_Parameters.Calculation_Method == Calculation_Method.Complex))
			{
				Equation = null;
			}

		}
	}
}
