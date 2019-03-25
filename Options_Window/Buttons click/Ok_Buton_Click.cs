using System;
using System.Windows;

namespace Options_Window
{
    partial class OptionsWindow
    {
        private void Ok_Buton_Click(object sender, RoutedEventArgs e)
        {
            Apply_Option_Change(Options);

            this.Close();
        }
    }
}
