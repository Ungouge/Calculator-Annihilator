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

namespace Calculator_Annihilator
{
    partial class Options_Window
    {
        partial class Font_Size_List_Context
        {
            private Font_Size_List_Item Set_Current_Font_Size_In_ComboBox(Font_Size_Type current_Font_Size)
            {
                foreach (Font_Size_List_Item item in Font_Size_List_Items_List)
                {
                    if (item.Font_Size == current_Font_Size)
                        return item;
                }

                return null;
            }
        }
    }
}

