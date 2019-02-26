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
            private Options_Window Options_Window;

            public List<Font_Size_List_Item> Font_Size_List_Items_List { get; set; }

            public Font_Size_List_Item Font_Size_List_ComboBox_SelectedItem { get; set; }

            public Font_Size_List_Context(Options_Window _Options_Window)
            {
                Options_Window = _Options_Window;

                Font_Size_List_Items_List = Set_Font_Size_List_Items();

                Font_Size_List_ComboBox_SelectedItem =
                     Set_Current_Font_Size_In_ComboBox(Options_Window.Options.Font_Size_Type);
            }
        }
    }
}
