﻿using System;
using System.ComponentModel;

namespace Calculator_Annihilator
{
    partial class Options_Window
    {
        partial class Numeral_System_List_Context
        {
            partial class Numeral_System_List_Item : INotifyPropertyChanged
            {
                public event PropertyChangedEventHandler PropertyChanged;

                /// <summary>
                /// Handles changed events for property of passed Name
                /// </summary>
                protected internal void On_Property_Change(string Property_Name)
                {
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs(Property_Name));
                    }
                }
            }
        }
    }
}