using System;
using System.Windows;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Sets propeties' values of GUI elements based on size of window.
    /// </summary>
    public partial class Window_Dynamic_Parameters
    {
        /// <summary>
        /// Construct new Window_Dynamic_Parameters
        /// </summary>
        public Window_Dynamic_Parameters(string[] properties_Names_To_Handle)
        {
            Names_Of_properties_To_Handle = properties_Names_To_Handle;
        }

        /// <summary>
        /// Construct new Window_Dynamic_Parameters
        /// </summary>
        public Window_Dynamic_Parameters(Window Window_To_Handle, string[] Properties_Names_To_Handle, double initial_Heigth, double initial_Width)
             : this(Properties_Names_To_Handle, initial_Heigth, initial_Width)
        {
            Current_Window = Window_To_Handle;
        }

        /// <summary>
        /// Construct new Window_Dynamic_Parameters
        /// </summary>
        public Window_Dynamic_Parameters(string[] Properties_Names_To_Handle, double initial_Heigth, double initial_Width)
            : this( Properties_Names_To_Handle)
        {
            _Window_Height = initial_Heigth;
            _Window_Width = initial_Width;
        }
    }
}