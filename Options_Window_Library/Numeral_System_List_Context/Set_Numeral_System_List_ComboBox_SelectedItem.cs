﻿using System;
using System.Windows;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        private Item_Numeral_System_List_Control Set_Numeral_System_List_ComboBox_SelectedItem(sbyte current_Numeral_System_Code)
        {
            Item_Numeral_System_List_Control List_Control = null;

            try
            {
                List_Control = _Numeral_System_List_Items_List.Find_Numeral_System_Item(current_Numeral_System_Code);
            }
            catch (Exception e )
            {
                List_Control = null;
                MessageBox.Show(e.Message);
            }

            return List_Control;
        }
    }
}

