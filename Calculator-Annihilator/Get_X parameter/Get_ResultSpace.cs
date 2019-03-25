using System;
using System.Windows.Controls;
using IMainWindow_Parameters;

namespace Calculator_Annihilator
{
    partial class MainWindow : IMainWindow_Get_ResultSpace
    {
        public TextBox Get_ResultSpace
        {
            get
            {
                return ResultSpace;
            }
        }
    }
}
