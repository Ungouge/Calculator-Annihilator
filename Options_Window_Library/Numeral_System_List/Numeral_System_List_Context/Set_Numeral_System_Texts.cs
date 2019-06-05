using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        /// <summary>
        /// Sets texts for list_Item in Numeral_System_Items_List.
        /// </summary>
        public void Set_Numeral_System_Texts(IStandard_Messages_Translate standard_Messages)
        {
            foreach (Numeral_System_List_Content list_Content in Numeral_System_List_Items_List)
            {
                if (list_Content is Numeral_System_List_Item list_Item)
                {
                    string new_Numeral_System_Name = Numeral_System.Numeral_System_Dictionary_Name(
                        list_Item.Numeral_System_Code, standard_Messages);

                    list_Item.Set_Numeral_System_Name(new_Numeral_System_Name);
                }
            }
        }
    }
}