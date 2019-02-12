using System;
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
            protected internal Bindable_Resources(MainWindow mainWindow, double initaial_Height, double initial_Width)
            {
                Current_Window = mainWindow;
                Window_Height = initaial_Height;
                Window_Width = initial_Width;
            }
        }
    }
}