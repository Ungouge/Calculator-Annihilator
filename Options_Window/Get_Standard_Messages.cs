﻿using System;
using Common_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        public IStandard_Messages_Translate Get_Standard_Messages
        {
            get
            {
                return MainWindow.Get_Standard_Messages;
            }
        }
    }
}
