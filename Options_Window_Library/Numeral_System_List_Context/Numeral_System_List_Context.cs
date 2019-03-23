using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Numeral_System_List_CombBox.
    /// </summary>
    public partial class Numeral_System_List_Context
    {
        internal IStandard_Messages_Translate Standard_Messages;

        private Numeral_System_Items_List _Numeral_System_List_Items_List { get; set; }

        public List<Numeral_System_List_Content> Numeral_System_List_Items_List
        {
            get
            {
                return _Numeral_System_List_Items_List.Get_Numeral_System_Items_List;
            }
        }

        public Numeral_System_List_Item Numeral_System_List_ComboBox_SelectedItem { get; set; }

        /// <summary>
        /// Constructs new Numeral_System_List_Context for given OptionsWindow.
        /// </summary>
        public Numeral_System_List_Context(Bindable_Resources Bindable_Resources, IStandard_Messages_Translate _Standard_Messages, sbyte numeral_System_Code)
        {
            Standard_Messages = _Standard_Messages;

            _Numeral_System_List_Items_List = new Numeral_System_Items_List(this, Bindable_Resources, Standard_Messages);

            Numeral_System_List_ComboBox_SelectedItem =
                 Set_Numeral_System_List_ComboBox_SelectedItem(numeral_System_Code);
        }
    }
}
