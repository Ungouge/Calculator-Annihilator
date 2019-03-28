﻿using System;
using System.Collections.Generic;
using System.Windows;
using Options_Library;
using Windows_Structure;

namespace Options_Window
{
    partial class OptionsWindow
    {
        private void Apply_In_All_Buton_Click(object sender, RoutedEventArgs e)
        {
            foreach (IGet_MainWindow_Parameters mainWindow in Windows_Manager.Get_MainWindows_List)
            {
                Apply_Option_Change(mainWindow.Get_Options);
            }

            Option_Change_Command_List = new List<IChange_Option_Command>();
        }
    }
}