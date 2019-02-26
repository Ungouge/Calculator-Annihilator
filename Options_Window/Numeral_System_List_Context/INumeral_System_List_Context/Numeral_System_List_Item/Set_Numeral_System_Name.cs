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

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_List_Item
        {
            internal void Set_Numeral_System_Name(string new_Numeral_System_Name)
            {
                Numeral_System_List_Item_Text = new_Numeral_System_Name;
                On_Property_Change("Numeral_System_List_Item_Text");
            }
        }
    }
}
