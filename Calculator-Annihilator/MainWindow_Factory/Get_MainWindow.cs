using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StartUpWindowBase;

namespace Calculator_Annihilator
{
    public partial class MainWindow_Factory
    {
        public Start_Up_Window_Base Get_MainWindow
        {
            get
            {
                return new MainWindow(Options_Storage);
            }
        }
    }
}
