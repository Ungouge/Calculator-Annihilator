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
            protected internal Bindable_Resources(MainWindow mainWindow)
            {
                Current_Window = mainWindow;
            }
        }
    }
}