using System;
using Calculator_Annihilator;
using Common_Library;

namespace Start_Up_Window
{
    partial class MainWindow_Factory
    {
        public IMainWindow Get_MainWindow
        {
            get
            {
                return new MainWindow(Options);
            }
        }
    }
}
