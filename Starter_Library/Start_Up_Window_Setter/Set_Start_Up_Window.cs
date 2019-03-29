using System;
using Start_Up_Window;
using Common_Library;

namespace Starter_Library
{
    partial class Start_Up_Window_Setter
    {
        private IStart_Up_Window Set_Start_Up_Window(bool Do_load_Hello_Window)
        {
            IStart_Up_Window Window_To_Load;

            if (Do_load_Hello_Window == false)
            {
                Window_To_Load = new MainWindow_Factory(Options).Get_MainWindow;
            }
            else
            {
                Window_To_Load = null; // Hello_Window();
            }

            return Window_To_Load;
        }
    }
}
