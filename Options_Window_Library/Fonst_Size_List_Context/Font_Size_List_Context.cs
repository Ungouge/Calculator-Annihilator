using System;
using System.Collections.Generic;
using Options_Library;
using Common_Library;


namespace Options_Window_Library
{
    public partial class Font_Size_List_Context
    {
        private IStandard_Messages_Translate Standard_Messages;

        public List<Font_Size_List_Item> Font_Size_List_Items_List { get; set; }

        public Font_Size_List_Item Font_Size_List_ComboBox_SelectedItem { get; set; }

        public Font_Size_List_Context(IStandard_Messages_Translate _Standard_Messages, Font_Size_Type _Font_Size_Type)
        {
            Standard_Messages = _Standard_Messages;

            Font_Size_List_Items_List = Set_Font_Size_List_Items();

            Font_Size_List_ComboBox_SelectedItem =
                    Set_Current_Font_Size_In_ComboBox(_Font_Size_Type);
        }
    }
}