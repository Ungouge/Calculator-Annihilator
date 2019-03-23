﻿using System;
using System.ComponentModel;

namespace Options_Window_Library
{
    partial class Comma_Type_List_Context : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Handles changed events for property of passed Name
        /// </summary>
        protected internal void On_Property_Change(string Property_Name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property_Name));
        }

        public Item_Comma_Type_Control Return_Current_Comma_Type_Item()
        {
            foreach (Comma_Type_List_Content item_Content in Comma_Type_Items_List)
            {
                if (item_Content is Item_Comma_Type_Control item_Control)
                {
                    return item_Control;
                }
            }

            return null;
        }
    }
}