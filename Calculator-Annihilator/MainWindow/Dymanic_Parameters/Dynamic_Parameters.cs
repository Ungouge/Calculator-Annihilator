using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Sets dynamic bindable resources of GUI elements of MainWindow.
        /// </summary>
        internal partial class Dynamic_Parameters : Window_Dynamic_Parameters
        {
            /// <summary>
            /// Contains names of fields that should be recalculated at MainWindow state change
            /// </summary>
            static private string[] Properties_Names_To_Handle = new string[]
            {
                "Button_FontSize", "WorkSpace_FontSize", "ResultSpace_FontSize", "Calculation_Type_Radio_Buttons_FontSize"
            };

            /// <summary>
            /// Constructs new MainWindow_Dynamic_Parameters class
            /// </summary>
            protected internal Dynamic_Parameters(Settings_File_Reader _Settings_File_Reader)
                : base(Properties_Names_To_Handle)
            {
                Current_Window = (MainWindow)Application.Current.MainWindow;
                _Settings_File_Reader.Push_Dynamic_Settings(this);
            }
        }
    }
}