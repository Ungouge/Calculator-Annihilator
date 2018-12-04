using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Sets propeties' values of GUI elements based on size of window.
    /// </summary>
    public partial class Window_Dynamic_Parameters
    {
        public Window_Dynamic_Parameters(Window Window_To_Handle): this (Window_To_Handle, new string[] { "xyz" })
        {
            //empty
        }

        public Window_Dynamic_Parameters(Window Window_To_Handle, string[] Properties_Names_To_Handle)
        {
            Current_Window = Window_To_Handle;
            Names_Of_properties_To_Handle = Properties_Names_To_Handle;
        }
    }
}