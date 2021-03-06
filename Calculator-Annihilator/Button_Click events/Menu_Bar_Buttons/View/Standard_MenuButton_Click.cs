﻿using System;
using System.Windows;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class MainWindow //Standard_MenuButton_Click
    {
        /// <summary>
        /// Switches calculator to standard view mode.
        /// </summary>
        private void Standard_MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Options.Set_Calculator_Mode( Calculator_Mode.Standard);

            Calculator_Buttons_Panel_Setter();
        }
    }
}
