using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class Window_Dynamic_Parameters
    {
        public void Window_State_Changed(object sender, EventHandler e)
        {
            Push_Recalculations();
        }
    }
}
