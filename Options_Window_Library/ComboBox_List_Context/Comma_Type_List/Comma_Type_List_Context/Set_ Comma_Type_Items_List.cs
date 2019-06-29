using System;
using System.Collections.Generic;

namespace Options_Window_Library
{
    partial class Comma_Type_List_Context
    {
        /// <summary>
        /// Sets list of Comma_Type_List_Content.
        /// </summary>
        private List<IComma_Type_List_Item> Set_Comma_Type_Items_List()
        {
            List<IComma_Type_List_Item> Output_List = new List<IComma_Type_List_Item>();

            foreach (string comma_Type in Commas_Type)
            {
                Output_List.Add(Factory.Get_Item(comma_Type));
            }

            Output_List.Add(Factory.Get_Add_New_Comma_Type());

            return Output_List;
        }
    }
}
