using System;
using System.Windows;

namespace Calculator_Annihilator
{
	partial class MainWindow
	{
		/// <summary>
		/// Switches calculator to single calculation mode.
		/// </summary>
		private void Single_Calculations_Button_Checked(object sender, RoutedEventArgs e)
        {
            options.Calculation_Method = Calculation_Method.Single;

            Complex_To_Single();

            Set_Specialized_Buttons();
		}

		/// <summary>
		/// Take text from workspace and converts it as it would be inserted in single calculation mode.
		/// </summary>
		private void Complex_To_Single()
        {
            Complex_To_Single_WorkSpace_Converter _Converter =
                new Complex_To_Single_WorkSpace_Converter(WorkSpace.Text, Current_Numeral_System, this);
            _Converter.Convert_To_Single();
        }
	}
}
