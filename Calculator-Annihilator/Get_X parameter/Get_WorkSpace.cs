using System;
using System.Windows.Controls;
using IMain_Window;

namespace Calculator_Annihilator
{
    partial class MainWindow : IMainWindow_Get_WorkSpace
    {
        public TextBox Get_WorkSpace
        {
            get
            {
                return WorkSpace;
            }
        }
    }
}
