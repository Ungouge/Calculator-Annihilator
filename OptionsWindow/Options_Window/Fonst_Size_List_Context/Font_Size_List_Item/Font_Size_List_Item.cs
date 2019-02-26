using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OptionsWindow
{
    partial class Options_Window
    {
        partial class Font_Size_List_Context
        {
            public partial class Font_Size_List_Item
            {
                public string Font_Size_Name { get; set; }

                public string Font_Size_Symbol_Uri { get; set; }

                internal Font_Size_Type Font_Size;

                internal Font_Size_List_Item(Options_Window _Options_Window, Font_Size_Type _Font_Size)
                {
                    Font_Size = _Font_Size;

                    Font_Size_Name = _Options_Window.Options.Standard_Messages.Translate(Font_Size.ToString() + "_Font_Size");

                    Font_Size_Symbol_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Image\Font_Size\" + Font_Size.ToString() + "_Flag.png";
                }

            }
        }
    }
}
