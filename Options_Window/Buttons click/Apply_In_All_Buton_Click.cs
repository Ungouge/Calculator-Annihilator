using System;
using System.Collections.Generic;
using System.Windows;
using Common_Library;
using Windows_Structure;

namespace Options_Window
{
    partial class OWXYZ
    {
        private void Apply_In_All_Buton_Click(object sender, RoutedEventArgs e)
        {
            foreach (IMainWindow mainWindow in Windows_Manager.Get_MainWindows_List)
            {
                Apply_Option_Change(mainWindow.Get_Options);
            }

            Option_Change_Command_List = new List<IChange_Option_Command>();
        }
    }
}
