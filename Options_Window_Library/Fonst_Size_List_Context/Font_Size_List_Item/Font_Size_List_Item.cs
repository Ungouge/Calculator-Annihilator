﻿using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Font_Size_List_Context
    {
        public partial class Font_Size_List_Item
        {
            public string Font_Size_Name { get; set; }

            public string Font_Size_Symbol_Uri { get; set; }

            internal Font_Size_Type Font_Size;

            internal Font_Size_List_Item(IStandard_Messages_Translate Standard_Messages, Font_Size_Type _Font_Size)
            {
                Font_Size = _Font_Size;

                Font_Size_Name = Standard_Messages.Translate(Font_Size.ToString() + "_Font_Size");

                Font_Size_Symbol_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Image\Font_Size\" + Font_Size.ToString() + "_Flag.png";
            }
        }
    }
}