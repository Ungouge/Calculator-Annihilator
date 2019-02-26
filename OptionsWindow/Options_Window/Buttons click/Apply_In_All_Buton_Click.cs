using System;
using System.Collections.Generic;
using System.Windows;

namespace OptionsWindow
{
    partial class Options_Window
    {
        private void Apply_In_All_Buton_Click(object sender, RoutedEventArgs e)
        {
            foreach (MainWindow mainWindow in Windows_Structure_Manager.Get_MainWindows_List)
            {
                Apply_Option_Change(mainWindow.options);
            }

            Option_Change_Command_List = new List<IChange_Option_Command>();
        }
    }
}
