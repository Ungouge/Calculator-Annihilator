using System;
using Common_Library;

namespace Starter_Library
{
    /// <summary>
    /// Class to read options file or generate new if there is non.
    /// </summary>
    public partial class Settings_File_Reader : ISettings_File_Reader
    {
        public void Set_Do_Load_Hello_Window_Next_Run()
        {
            bool Do_Load_Hello_Window_Pernamently = (bool)Settings["Load_Hello_Window_Pernamently"];

            if (Do_Load_Hello_Window_Pernamently == true)
            {
                Load_Hello_Window_Next_Run.Pernamently_Load_Hello_Window();

                return;
            }

            bool Do_Load_Hello_Window = (bool)Settings["Load_Hello_Window_Next_Run"];

            if (Do_Load_Hello_Window == true)
                Load_Hello_Window_Next_Run.Load_Hello_Window_Only_Next_Run();
            else
                Load_Hello_Window_Next_Run.Dont_Load_Hello_Window();
        }
    }
}