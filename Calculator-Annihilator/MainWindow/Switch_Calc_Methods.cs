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
	partial class MainWindow
	{
		private void Single_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
			Clear_WorkSpace();
			ResultSpace.Text = ""; //Equals_Complex(WorkSpace.Text).ToString(); Bring Back when Complex is coplete

			no_Calculation_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;

			Disable_Complex_Buttons();
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

			if (no_Calculation_Sign_Single == false)
				newWorkSpaceText += Calculation_Sign_Single.ToString();

			newWorkSpaceText += WorkSpace.Text;

			Reset_WorkSpace_Text(newWorkSpaceText);

			no_Calculation_Sign_Single = true;
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
