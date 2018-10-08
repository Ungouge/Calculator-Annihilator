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
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Numeral_System = 10;
			Current_Numerical_System = new Numerical_System_Signs(Numeral_System);
			Numerical_System_Signs = Current_Numerical_System.System_Digits;
			//WorkSpace.Text = "(58, 53 + 57) - 54, 2 * 25";

		}

		private void Single_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
			Clear_WorkSpace();
			ResultSpace.Text = Equals_Complex(WorkSpace.Text).ToString();

			no_Calculation_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;

			Disable_Complex_Buttons();
		}

		private void Enable_Complex_Buttons()
		{
			Button_Open_Bracket.IsEnabled = true;
			Button_Close_Bracket.IsEnabled = true;
		}

		private void Complex_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
			string newWorkSpaceText= "";

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

		private void Disable_Complex_Buttons()
		{
			Button_Open_Bracket.IsEnabled = false;
			Button_Close_Bracket.IsEnabled = false;
		}

		private void Reset_WorkSpace_Text(string newWorkSpaceText)
		{
			Clear_WorkSpace();

			Insert_To_WorkSpace(newWorkSpaceText);
		}
	}
}
