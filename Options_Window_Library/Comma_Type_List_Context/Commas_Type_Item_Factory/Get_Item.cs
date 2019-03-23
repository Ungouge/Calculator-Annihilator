using System;

namespace Options_Window_Library
{
    partial class Commas_Type_Item_Factory
    {
        /// <summary>
        /// Gets instatiated Item_Comma_Type_Control.
        /// </summary>
        internal Item_Comma_Type_Control Get_Item(string comma)
        {
            return new Item_Comma_Type_Control(Bindable_Resources, comma);
        }
    }
}
