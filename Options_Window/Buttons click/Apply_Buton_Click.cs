﻿using System;
using System.Collections.Generic;
using System.Windows;
using Options_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        private void Apply_Buton_Click(object sender, RoutedEventArgs e)
        {
            Apply_Option_Change(Options);

            Option_Change_Command_List = new List<IChange_Option_Command>();
        }
    }
}
