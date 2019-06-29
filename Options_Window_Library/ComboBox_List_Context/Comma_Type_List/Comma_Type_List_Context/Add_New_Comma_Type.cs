using System;
using System.Linq;

namespace Options_Window_Library
{
    partial class Comma_Type_List_Context
    {
        /// <summary>
        /// Adds given comma string to OptionsWIndow.
        /// </summary>
        internal void Add_New_Comma_Type(string new_Comma)
        {
            Commas_Type = Commas_Type.Concat(new string[] { new_Comma }).ToArray();

            Comma_Type_Items_List = Set_Comma_Type_Items_List();

            On_Property_Change("Comma_Type_Items_List");
        }
    }
}
