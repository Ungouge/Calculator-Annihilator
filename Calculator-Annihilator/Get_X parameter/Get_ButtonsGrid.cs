﻿using System;
using System.Windows.Controls;
using IMain_Window;

namespace Calculator_Annihilator
{
    partial class MainWindow : IMainWindow_Get_ButtonsGrid
    {
        public Grid Get_ButtonsGrid
        {
            get
            {
                return ButtonsGrid;
            }
        }
    }
}
