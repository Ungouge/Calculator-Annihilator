﻿using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Sets dynamic bindable resources of GUI elements of MainWindow.
        /// </summary>
        internal partial class Bindable_Resources
        {
            /// <summary>
            /// Constructs new Bindable Resources class
            /// </summary>
            protected internal Bindable_Resources(MainWindow _MainWindow, Settings_File_Reader _Settings_File_Reader)
            {
                Current_Window = (MainWindow)Application.Current.MainWindow;
                _Settings_File_Reader.Push_Dynamic_Settings(this);
                Set_Texts(_MainWindow);
            }
        }
    }
}