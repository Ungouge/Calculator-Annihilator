using System;
using Calculator_Annihilator_Library;

namespace Calculator_Annihilator
{
    partial class Settings_File_Reader
    {
        /// <summary>
        /// Returns options read from the settings file.
        /// </summary>
        internal IOptions Options_Generator(MainWindow mainWindow)
        {
            return (new Options_Factory(mainWindow)).Get_Options(options);
        }
    }
}
