using System;
using System.Windows;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        private Item_Numeral_System_List Set_Numeral_System_List_ComboBox_SelectedItem(sbyte current_Numeral_System_Code)
        {
            Item_Numeral_System_List List_Item = null;

            List_Item = Find_Numeral_System_Item(current_Numeral_System_Code);

            return List_Item;
        }
    }
}

