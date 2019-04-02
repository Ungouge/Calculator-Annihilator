using System;

namespace Common_Library
{
    public static partial class Load_Hello_Window_Next_Run
    {
        public static void Load_Hello_Window_Only_Next_Run()
        {
            Load_Hello_Window_Pernamently = false;

            _Do_Load = true;
        }
    }
}
