using System;

namespace Options_Window_Library
{
    partial class Number_Notation_List_Context
    {
        partial class Number_Notation_List_Item
        {
            /// <summary>
            /// Sets Number_Notation_Name.
            /// </summary>
            internal void Set_Number_Notation_Name(string new_Number_Notation_Name)
            {
                Number_Notation_Name = new_Number_Notation_Name;
                On_Property_Change("Number_Notation_Name");
            }
        }
    }
}
