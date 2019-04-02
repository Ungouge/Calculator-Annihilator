using System;
using Calculator_Annihilator;
using Common_Library;
using StartUpWindowBase;

namespace Starter_Library
{
    partial class Start_Up_Window_Setter : IStart_Up_Window_Setter
    {
        public Start_Up_Window_Base Get_Start_Up_Window
        {
            get
            {
                Start_Up_Window_Base Window_To_Load;

                if (Load_Hello_Window_Next_Run.Do_Load == false)
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
}
