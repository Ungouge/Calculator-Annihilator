﻿using System;
using System.ComponentModel;

namespace Options_Window
{
    partial class Font_Size_List_Context
    {
        partial class Font_Size_List_Item : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Handles changed events for property of passed Name
            /// </summary>
            protected internal void On_Property_Change(string Property_Name)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property_Name));
            }
        }
    }
}