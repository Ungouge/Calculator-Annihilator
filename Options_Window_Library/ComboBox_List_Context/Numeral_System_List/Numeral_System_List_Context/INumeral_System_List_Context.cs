using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Common_Library;

namespace Options_Window_Library
{
    public interface INumeral_System_List_Context
    {
        List<INumeral_System_List_Content> Numeral_System_List_Items_List { get; }

        IItem_Numeral_System_List Numeral_System_List_ComboBox_SelectedItem { get; set; }

        void Set_Numeral_System_Texts(IStandard_Messages_Translate standard_Messages);
    }
}
