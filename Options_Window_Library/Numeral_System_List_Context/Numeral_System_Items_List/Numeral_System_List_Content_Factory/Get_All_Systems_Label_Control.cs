using System;
using IOptions_Window;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_Items_List
        {
            partial class Numeral_System_List_Content_Factory
            {
                internal Label_Numeral_System_List_Control Get_All_Systems_Label_Control
                {
                    get
                    {
                        return new Label_Numeral_System_List_Control(
                            Bindable_Resources.ComboBox_Element_Width,
                            Standard_Messages.Translate("All_Numeral_system"));
                    }
                }
            }
        }
    }
}
