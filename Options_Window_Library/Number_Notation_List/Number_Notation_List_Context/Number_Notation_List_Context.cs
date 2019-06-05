using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Number_Notation_List_CombBox.
    /// </summary>
    public partial class Number_Notation_List_Context
    {
        private IStandard_Messages_Translate Standard_Messages;

        public List<Number_Notation_List_Item> Number_Notation_List_Items_List { get; set; }

        public Number_Notation_List_Item Number_Notation_List_ComboBox_SelectedItem { get; set; }

        /// <summary>
        /// Constructs new Number_Notation_List_Context for given OptionsWindow.
        /// </summary>
        public Number_Notation_List_Context(IStandard_Messages_Translate _Standard_Messages, Number_Notation Number_Notation)
        {
            Standard_Messages = _Standard_Messages;

            Number_Notation_List_Items_List = Set_Number_Notation_List_Items();

            Number_Notation_List_ComboBox_SelectedItem =
                    Set_Current_Number_Notation_In_ComboBox(Number_Notation);
        }
    }
}
