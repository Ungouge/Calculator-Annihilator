using System;
using System.Collections.Generic;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class Options_Window : Window
    {
        private void Apply_Buton_Click(object sender, RoutedEventArgs e)
        {
            Apply_Option_Change(Options);

            Option_Change_Command_List = new List<IChange_Option_Command>();
        }
    }
}
