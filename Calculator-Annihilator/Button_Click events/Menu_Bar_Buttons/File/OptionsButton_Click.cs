using System;
using System.Windows;
using Options_Window;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            IOptionsWindow_Show OWindow = new Options_Window.OptionsWindow(this);
            OWindow.Show();
        }
    }
}