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
			numerical_System_Signs = Current_Numerical_System.System_Digits;
		}

		private void Single_Calculations_Button_Checked(object sender, RoutedEventArgs e)
		{
			Parse_WorkSpace();
			//ResultSpace.Text
			//? Do make optional, to calculate what is in work space?? 
			/*WorkSpace.Text = WorkSpace.Text.Insert(0, Calculation_Sign_Single.ToString());
			WorkSpace.Text = WorkSpace.Text.Insert(0, first_Number_In_Equation_Single.ToString());
			
			WorkSpace.CaretIndex += Calculation_Sign_Single.ToString().Length + 1;
			WorkSpace.Focus();*/ // Propably wrong

			no_Calculation_Sign_Single = true;
			no_First_Number_In_Equation_Single = true;
		}
	}
}
