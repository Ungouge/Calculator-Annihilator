using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Calculator_Mode_List_Context
    {
        private ICalculator_Mode_List_Item Set_Current_Calculator_Mode_In_ComboBox(Calculator_Mode current_Calculator_Mode)
        {
            foreach (Calculator_Mode_List_Item Item in Calculator_Mode_Items_List)
            {
                if (Item.Calculator_Mode == current_Calculator_Mode)
                    return Item;
            }

            return null;
        }
    }
}
