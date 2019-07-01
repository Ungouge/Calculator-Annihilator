using System;
using System.Collections.Generic;
using Options_Library;
using Common_Library;


namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Font_Size_List_CombBox.
    /// </summary>
    internal partial class Font_Size_List_Context : ComboBox_List_Context, IFont_Size_List_Context
    {
        public List<IFont_Size_List_Item> Font_Size_Items_List { get; private set; }

        public IFont_Size_List_Item Font_Size_List_ComboBox_SelectedItem { get; set; }

        /// <summary>
        /// Constructs new Font_Size_List_Context for given OptionsWindow.
        /// </summary>
        internal Font_Size_List_Context(IStandard_Messages_Translate Standard_Messages, Font_Size_Type _Font_Size_Type)
        {
            Font_Size_Items_List = Set_Font_Size_List_Items( Standard_Messages);

            Font_Size_List_ComboBox_SelectedItem =
                    Set_Current_Font_Size_In_ComboBox(_Font_Size_Type);
        }
    }
}