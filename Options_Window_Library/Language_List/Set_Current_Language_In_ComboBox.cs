using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Langauge_List_Context
    {
        private Langauge_List_Items Set_Current_Language_In_ComboBox(Languages current_Language)
        {
            foreach (Langauge_List_Items item in Langauge_List_Items_List)
            {
                if (item.Language == current_Language)
                    return item;
            }

            return null;
        }
    }
}