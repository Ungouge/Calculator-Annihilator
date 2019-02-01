using System;

namespace Calculator_Annihilator
{
    partial class Settings_File_Reader
    {
        /// <summary>
        /// Reads settings file and sets dynamic main window settings
        /// </summary>
        internal void Push_Dynamic_Settings(MainWindow.Dynamic_Parameters Dynamic_Parameters)
        {
            Dynamic_Parameters.Window_Height = initial_Height;
            Dynamic_Parameters.Window_Width = initial_Width;
        }
    }

}
