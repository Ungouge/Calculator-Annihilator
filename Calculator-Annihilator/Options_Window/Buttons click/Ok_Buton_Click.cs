using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class Options_Window
    {
        private void Ok_Buton_Click(object sender, RoutedEventArgs e)
        {
            Apply_Option_Change(Options);

            this.Close();
        }
    }
}
