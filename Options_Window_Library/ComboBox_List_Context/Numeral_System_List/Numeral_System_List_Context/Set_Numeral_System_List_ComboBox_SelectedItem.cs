using System;
using System.Windows;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        private Item_Numeral_System_List Set_Numeral_System_List_ComboBox_SelectedItem(sbyte current_Numeral_System_Code)
        {
            foreach (Item_Numeral_System_List List_Item in Items_List)
                if (List_Item.Numeral_System_Code == current_Numeral_System_Code)
                    return List_Item;

            return null;
        }
    }
}

