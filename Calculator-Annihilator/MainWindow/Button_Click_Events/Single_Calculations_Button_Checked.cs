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
            GUI_Dynamic_Parameters.Calculation_Method = Calculation_Method.Single;

            try
            {
                Complex_To_Single();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Disable_Complex_Buttons();
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
