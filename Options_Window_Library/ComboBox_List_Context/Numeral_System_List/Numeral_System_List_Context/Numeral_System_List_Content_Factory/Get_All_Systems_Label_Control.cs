using System;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_List_Content_Factory
        {
            /// <summary>
            /// Gets label for all numeral systems.
            /// </summary>
            internal Label_Numeral_System_List Get_All_Systems_Label_Control
            {
                get
                {
                    return new Label_Numeral_System_List(Standard_Messages.Translate("All_Numeral_system"));
                }
            }
        }
    }
}
