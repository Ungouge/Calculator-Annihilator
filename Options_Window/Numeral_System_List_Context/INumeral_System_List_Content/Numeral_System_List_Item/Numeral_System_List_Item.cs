﻿using System;
using System.Windows.Controls;
using Common_Library;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        public partial class Numeral_System_List_Item : INumeral_System_List_Item
        {
            public string Numeral_System_List_Content_Text { get; set; }

            public sbyte Numeral_System_Code { get; private set; }

            public string Pin_Image_Uri { get; set; }

            public double Text_Width { get; set; }

            public double Image_Width { get; set; }

            public UserControl Content_Control { get; set; }

            public bool Is_Enabled { get { return true; } }

            internal Numeral_System_List_Item(OWXYZ _OptionsWindow, sbyte _numeral_System_Code)
                : this(_numeral_System_Code, _OptionsWindow)
            {
                Pin_Image_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Clear.png";
            }

            protected Numeral_System_List_Item(sbyte _numeral_System_Code, OWXYZ _OptionsWindow)
            {
                Numeral_System_Code = _numeral_System_Code;

                Numeral_System_List_Content_Text = Numeral_System.Numeral_System_Dictionary_Name(
                    Numeral_System_Code, _OptionsWindow.Options.Standard_Messages);

                Image_Width = _OptionsWindow._Bindable_Resources.ComboBox_List_Image_Height;

                Text_Width = _OptionsWindow._Bindable_Resources.ComboBox_Element_Width - Image_Width;

                Content_Control = new Item_Numeral_System_List_Control();
            }

        }
    }
}
