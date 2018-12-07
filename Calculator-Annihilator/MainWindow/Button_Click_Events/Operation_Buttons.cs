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
			if (Convert.ToBoolean(Single_Calculations.IsChecked == true))
			{
				Equals_Single();
			}
			else if (Convert.ToBoolean(Complex_Calculations.IsChecked == true))
			{
				Reset_ResultSpace_Text(Equals_Complex(WorkSpace.Text).ToString());
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

			if (Convert.ToBoolean(Single_Calculations.IsChecked == true))
			{
				no_operand_Sign_Single = true;
				no_First_Number_In_Equation_Single = true;
			}
			else if (Convert.ToBoolean(Complex_Calculations.IsChecked == true))
			{
				Current_Complex_Equation = null;
			}

		}
	}
}
