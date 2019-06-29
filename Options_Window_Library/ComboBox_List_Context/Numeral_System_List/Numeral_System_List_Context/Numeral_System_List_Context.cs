using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Common_Library;
using Options_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Numeral_System_List_CombBox.
    /// </summary>
    internal partial class Numeral_System_List_Context : ComboBox_List_Context, INumeral_System_List_Context
    {
        public IItem_Numeral_System_List Numeral_System_List_ComboBox_SelectedItem { get; set; }

        private List<IItem_Numeral_System_List> Items_List;

        private List<Pinned_Item_Numeral_System_List> Pinned_Items_List;

        private Numeral_System_List_Content_Factory Factory;

        /// <summary>
        /// Constructs new Numeral_System_List_Context for given OptionsWindow.
        /// </summary>
        internal Numeral_System_List_Context( IStandard_Messages_Translate Standard_Messages, sbyte numeral_System_Code)
        {
            Factory = new Numeral_System_List_Content_Factory(this, Standard_Messages);

            Items_List = Set_Numeral_System_List();

            Pinned_Items_List = Set_Pinned_Numeral_System_List();

            Numeral_System_List_ComboBox_SelectedItem =
                 Set_Numeral_System_List_ComboBox_SelectedItem(numeral_System_Code);
        }
    }
}
