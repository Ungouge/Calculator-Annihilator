using System;

namespace Options_Window_Library
{
    partial class Commas_Type_Item_Factory
    {
        /// <summary>
        /// Gets instatiated Add_New_Comma_Type_Control.
        /// </summary>
        internal Add_New_Comma_Type_List_Item Get_Add_New_Comma_Type()
        {
            return new Add_New_Comma_Type_List_Item(Standard_Messages.Translate("Add_New_Comma"), Comma_Type_List_Context);
        }
    }
}