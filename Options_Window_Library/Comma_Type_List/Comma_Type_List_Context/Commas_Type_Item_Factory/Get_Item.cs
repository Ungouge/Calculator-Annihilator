using System;

namespace Options_Window_Library
{
    partial class Commas_Type_Item_Factory
    {
        /// <summary>
        /// Gets instatiated Item_Comma_Type_Control.
        /// </summary>
        internal Comma_Type_List_Item Get_Item(string comma)
        {
            return new Comma_Type_List_Item(comma);
        }
    }
}
