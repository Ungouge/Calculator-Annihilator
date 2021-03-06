﻿using System;
using System.Windows.Controls;
using Common_Library;

namespace Options_Window_Library
{
    partial class Bindable_Resources
    {
        /// <summary>
        /// Sets size of images in comboboxes according to currently setted font size.
        /// </summary>
        private double Set_ComboBox_List_Image_Size()
        {
            Formatted_Text_Getter formatted_Text =
                new Formatted_Text_Getter(new TextBlock() { Text = "Xyz" },
                Text_FontSize);

            return formatted_Text.Get_Text_Height;
        }
    }
}