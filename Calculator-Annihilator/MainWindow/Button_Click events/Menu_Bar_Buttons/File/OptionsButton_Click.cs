using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Options_Window Options_Window = new Options_Window(options);
            Options_Window.Show();
        }
    }
}