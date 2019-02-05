using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Sets dynamic bindable resources of GUI elements of MainWindow.
        /// </summary>
        internal partial class Dynamic_Parameters
        {
            /// <summary>
            /// Constructs new MainWindow_Dynamic_Parameters class
            /// </summary>
            protected internal Dynamic_Parameters(Settings_File_Reader _Settings_File_Reader)
            {
                Current_Window = (MainWindow)Application.Current.MainWindow;
                _Settings_File_Reader.Push_Dynamic_Settings(this);
            }

            ///// <summary>
            ///// Construct new Window_Dynamic_Parameters
            ///// </summary>
            //public Dynamic_Parameters(Window Window_To_Handle, string[] Properties_Names_To_Handle, double initial_Heigth, double initial_Width)
            //     : this(Properties_Names_To_Handle, initial_Heigth, initial_Width)
            //{
            //    Current_Window = Window_To_Handle;
            //}

            ///// <summary>
            ///// Construct new Window_Dynamic_Parameters
            ///// </summary>
            //public Dynamic_Parameters(string[] Properties_Names_To_Handle, double initial_Heigth, double initial_Width)
            //    : this(Properties_Names_To_Handle)
            //{
            //    _Window_Height = initial_Heigth;
            //    _Window_Width = initial_Width;
            //}
        }
    }
}