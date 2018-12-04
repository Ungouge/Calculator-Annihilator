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
        public MainWindow_Dynamic_Parameters(): base(Application.Current.MainWindow, new string[] { "Button_FontSize" })
        {
            //empty
        }
    }
}