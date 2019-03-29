using System;
using Options_Library;

namespace Starter_Library
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    public partial class Settings_File_Reader
    {
        public IOptions_Storage Get_Options_Storage
        {
            get
            {
                return Options;
            }
        }
    }
}
