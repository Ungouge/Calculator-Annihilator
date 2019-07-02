using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Calculation_Method_List_Context
    {
        private ICalculation_Method_List_Item Set_Current_Calculation_Method_In_ComboBox(Calculation_Method current_Calculation_Method)
        {
            foreach (Calculation_Method_List_Item Item in Calculation_Method_Items_List)
            {
                if (Item.Calculation_Method == current_Calculation_Method)
                    return Item;
            }

            return null;
        }
    }
}
