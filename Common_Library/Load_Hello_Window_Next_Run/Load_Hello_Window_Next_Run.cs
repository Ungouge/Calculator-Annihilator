using System;

namespace Common_Library
{
    public static partial class Load_Hello_Window_Next_Run
    {
        private static bool _Do_Load;

        public static bool Do_Load
        {
            get
            {
                if (Load_Hello_Window_Pernamently == true)
                    return true;

                return _Do_Load;
            }
        }

        public static bool Load_Hello_Window_Pernamently { get; private set; }
    }
}
