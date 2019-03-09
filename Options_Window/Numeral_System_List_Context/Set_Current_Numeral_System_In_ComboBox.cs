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
        private Numeral_System_List_Item Set_Current_Numeral_System_In_ComboBox(sbyte current_Numeral_System_Code)
        {
            foreach (INumeral_System_List_Content item in Numeral_System_List_Items_List)
            {
                if (item is Numeral_System_List_Item list_Item )
                    if(list_Item.Numeral_System_Code == current_Numeral_System_Code)
                        return list_Item;
            }

            return null;
        }
    }
}

