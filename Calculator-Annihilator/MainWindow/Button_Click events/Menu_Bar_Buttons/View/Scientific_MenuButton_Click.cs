using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class MainWindow //Scientific_MenuButton_Click
    {
        /// <summary>
        /// Switches calculator to scientific view mode.
        /// </summary>
        private void Scientific_MenuButton_Click(object sender, RoutedEventArgs e)
        {
            _Static_Resources.Calculator_Mode = Calculator_Mode.Scientific;

            Calculator_Buttons_Panel_Setter();
        }

    }
}
