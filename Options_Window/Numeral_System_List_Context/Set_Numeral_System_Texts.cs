using System;
using Common_Library;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        internal void Set_Numeral_System_Texts(Standard_Messages standard_Messages)
        {
            foreach (Numeral_System_List_Item list_Item in Numeral_System_List_Items_List)
            {
                string new_Numeral_System_Name = Numeral_System.Numeral_System_Dictionary_Name(
                    list_Item.Numeral_System_Code, standard_Messages);

                list_Item.Set_Numeral_System_Name(new_Numeral_System_Name);
            }
        }
    }
}