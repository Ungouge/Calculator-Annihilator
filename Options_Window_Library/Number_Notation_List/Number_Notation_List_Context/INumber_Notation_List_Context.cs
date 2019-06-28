using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    public interface INumber_Notation_List_Context
    {
        List<Number_Notation_List_Item> Number_Notation_List_Items_List { get; }

        Number_Notation_List_Item Number_Notation_List_ComboBox_SelectedItem { get; set; }

        void Set_Number_Notation_Texts(IStandard_Messages_Translate standard_Messages);
    }
}
