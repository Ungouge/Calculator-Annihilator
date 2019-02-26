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
        public partial class Font_Size_List_Context
        {
            private List<Font_Size_List_Item> Set_Font_Size_List_Items()
            {
                List<Font_Size_List_Item> Output_Items_List = new List<Font_Size_List_Item>();

                foreach (Font_Size_Type font_Size in (Font_Size_Type[])Enum.GetValues(typeof(Font_Size_Type)))
                {
                    Output_Items_List.Add(new Font_Size_List_Item(Options_Window, font_Size));
                }

                return Output_Items_List;
            }
        }
    }
}
