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
            partial class Font_Size_List_Item
            {
                internal void Set_Font_Size_Name(string new_Font_Size_Name)
                {
                    Font_Size_Name = new_Font_Size_Name;
                    On_Property_Change("Font_Size_Name");
                }
            }
        }
    }
}
