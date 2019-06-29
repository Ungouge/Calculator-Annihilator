using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Language_List_CombBox.
    /// </summary>
    internal partial class Langauge_List_Context : ComboBox_List_Context, ILangauge_List_Context
    {
        public List<Langauge_List_Items> Langauge_List_Items_List { get; private set; }

        public Langauge_List_Items Language_List_ComboBox_SelectedItem { get; set; }

        /// <summary>
        /// Constructs new Font_Size_List_Context for given OptionsWindow.
        /// </summary>
        internal Langauge_List_Context(IStandard_Messages_Translate Standard_Messages, Languages Current_Language)
        {
            Langauge_List_Items_List = Set_Languge_List_Items(Standard_Messages);

            Language_List_ComboBox_SelectedItem =
                    Set_Current_Language_In_ComboBox(Current_Language);
        }
    }
}
