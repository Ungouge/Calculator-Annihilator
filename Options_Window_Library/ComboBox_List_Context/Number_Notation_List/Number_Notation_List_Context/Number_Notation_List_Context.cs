using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Number_Notation_List_CombBox.
    /// </summary>
    internal partial class Number_Notation_List_Context : ComboBox_List_Context, INumber_Notation_List_Context
    {
        public List<Number_Notation_List_Item> Number_Notation_List_Items_List { get; private set; }

        public Number_Notation_List_Item Number_Notation_List_ComboBox_SelectedItem { get; set; }

        /// <summary>
        /// Constructs new Number_Notation_List_Context for given OptionsWindow.
        /// </summary>
        internal Number_Notation_List_Context(IStandard_Messages_Translate Standard_Messages, Number_Notation Number_Notation)
        {
            Number_Notation_List_Items_List = Set_Number_Notation_List_Items(Standard_Messages);

            Number_Notation_List_ComboBox_SelectedItem =
                    Set_Current_Number_Notation_In_ComboBox(Number_Notation);
        }
    }
}
