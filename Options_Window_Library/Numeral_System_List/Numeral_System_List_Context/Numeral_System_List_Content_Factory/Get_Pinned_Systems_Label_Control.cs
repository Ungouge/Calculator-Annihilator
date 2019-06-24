using System;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_List_Content_Factory
        {
            /// <summary>
            /// Gets label for pinned numeral systems.
            /// </summary>
            internal Label_Numeral_System_List Get_Pinned_Systems_Label_Control
            {
                get
                {
                    return new Label_Numeral_System_List(
                        Standard_Messages.Translate("Pinned_Numeral_Systems"));
                }
            }
        }
    }
}
