﻿using System;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_Items_List
        {
            partial class Numeral_System_List_Content_Factory
            {
                internal Label_Numeral_System_List_Control Get_Pinned_Systems_Label_Control
                {
                    get
                    {
                        return new Label_Numeral_System_List_Control(
                            OptionsWindow._Bindable_Resources.ComboBox_Element_Width,
                            OptionsWindow.Options.Standard_Messages.Translate("Pinned_Numeral_System"));
                    }
                }
            }
        }
    }
}
