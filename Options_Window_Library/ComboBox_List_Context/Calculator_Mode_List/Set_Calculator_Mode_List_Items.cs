using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    partial class Calculator_Mode_List_Context
    {
        /// <summary>
        /// Sets list of Calculator_Mode_List_Content.
        /// </summary>
        private List<ICalculator_Mode_List_Item> Set_Calculator_Mode_List_Items(IStandard_Messages_Translate Standard_Messages)
        {
            List<ICalculator_Mode_List_Item> Output_Items_List = new List<ICalculator_Mode_List_Item>();

            foreach (Calculator_Mode Calculator_Mode in (Calculator_Mode[])Enum.GetValues(typeof(Calculator_Mode)))
            {
                Output_Items_List.Add(new Calculator_Mode_List_Item(Standard_Messages, Calculator_Mode));
            }

            return Output_Items_List;
        }
    }
}
