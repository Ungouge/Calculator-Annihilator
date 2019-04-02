using System;
using Common_Library;
using Options_Library;

namespace Starter_Library
{
    partial class Do_Load_Hello_Window_Setter
    {
        public bool Get_Do_Load_Hello_Window
        {
            get
            {
                if (Options is Null_Options_Storage)
                    return true;

                if (Load_Hello_Window_Next_Run.Do_Load == true)
                    return true;

                return false;
            }
        }

    }
}
