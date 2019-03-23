using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    partial class Langauge_List_Context
    {
        /// <summary>
        /// Sets texts for list_Item in Font_Size_Items_List.
        /// </summary>
        private List<Langauge_List_Items> Set_Languge_List_Items()
        {
            List<Langauge_List_Items> Output_Items_List = new List<Langauge_List_Items>();

            foreach (Languages language in (Languages[]) Enum.GetValues(typeof(Languages)))
            {
                Output_Items_List.Add( new Langauge_List_Items(Standard_Messages, language));
            }

            return Output_Items_List;
        }
    }
}