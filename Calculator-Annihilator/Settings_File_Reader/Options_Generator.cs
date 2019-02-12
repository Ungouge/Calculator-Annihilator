using System;

namespace Calculator_Annihilator
{
    partial class Settings_File_Reader
    {
        /// <summary>
        /// Returns options read from the settings file.
        /// </summary>
        internal Options Options_Generator()
        {
            return new Options(options);
        }
    }
}
