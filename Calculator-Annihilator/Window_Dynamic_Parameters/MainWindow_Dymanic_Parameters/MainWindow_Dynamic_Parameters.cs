using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Sets propeties' values of GUI elements of MainWindow.
    /// </summary>
    public partial class MainWindow_Dynamic_Parameters: Window_Dynamic_Parameters
    {
        private MainWindow Current_Window;

        static private string[] Properties_Names_To_Handle = new string[] { "Button_FontSize" };

        public MainWindow_Dynamic_Parameters(double initial_Heigth, double initial_Width)
            : base(Properties_Names_To_Handle, initial_Heigth, initial_Width)
        {
            Current_Window = (MainWindow)Application.Current.MainWindow;
        }
    }
}