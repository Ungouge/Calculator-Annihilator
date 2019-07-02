using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    partial class Calculation_Method_List_Context
    {
        /// <summary>
        /// Sets list of Calculation_Method_List_Content.
        /// </summary>
        private List<ICalculation_Method_List_Item> Set_Calculation_Method_List_Items(IStandard_Messages_Translate Standard_Messages)
        {
            List<ICalculation_Method_List_Item> Output_Items_List = new List<ICalculation_Method_List_Item>();

            foreach (Calculation_Method Calculation_Method in (Calculation_Method[])Enum.GetValues(typeof(Calculation_Method)))
            {
                Output_Items_List.Add(new Calculation_Method_List_Item(Standard_Messages, Calculation_Method));
            }

            return Output_Items_List;
        }
    }
}
