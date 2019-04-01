using System;
using System.Windows;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class MainWindow //Scientific_MenuButton_Click
    {
        /// <summary>
        /// Switches calculator to scientific view mode.
        /// </summary>
        private void Scientific_MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Options.Set_Calculator_Mode (Calculator_Mode.Scientific);

            Calculator_Buttons_Panel_Setter();
        }

    }
}
