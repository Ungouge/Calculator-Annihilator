using System;
using Common_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        partial class Font_Size_List_Context
        {
            public partial class Font_Size_List_Item
            {
                public string Font_Size_Name { get; set; }

                public string Font_Size_Symbol_Uri { get; set; }

                internal Font_Size_Type Font_Size;

                internal Font_Size_List_Item(OWXYZ _OptionsWindow, Font_Size_Type _Font_Size)
                {
                    Font_Size = _Font_Size;

                    Font_Size_Name = _OptionsWindow.Options.Standard_Messages.Translate(Font_Size.ToString() + "_Font_Size");

                    Font_Size_Symbol_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Image\Font_Size\" + Font_Size.ToString() + "_Flag.png";
                }

            }
        }
    }
}
