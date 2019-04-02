using System;

namespace Common_Library
{
    static partial class Load_Hello_Window_Next_Run
    {
        public static void Dont_Load_Hello_Window()
        {
            Load_Hello_Window_Pernamently = false;

            _Do_Load = false;
        }
    }
}
