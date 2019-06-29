using System;
using System.Collections.Generic;
using Common_Library;
using Options_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Comma_Type_List_CombBox.
    /// </summary>
    internal partial class Comma_Type_List_Context: ComboBox_List_Context, IComma_Type_List_Context
    {
        private Commas_Type_Item_Factory Factory;

        internal string[] Commas_Type;

        public IComma_Type_List_Item Comma_Type_List_ComboBox_SelectedItem { get; set; }

        public List<IComma_Type_List_Item> Comma_Type_Items_List { get; private set; }

        /// <summary>
        /// Constructs new Comma_Type_List_Context for given OptionsWindow.
        /// </summary>
        internal Comma_Type_List_Context(IStandard_Messages_Translate Standard_Messages, IOptions_Provider Options_Provider)
        {
            Commas_Type = Options_Provider.Commas_Type_Array;

            Factory = new Commas_Type_Item_Factory(this, Standard_Messages);

            Comma_Type_Items_List = Set_Comma_Type_Items_List();

            Comma_Type_List_ComboBox_SelectedItem = Set_Comma_Type_List_ComboBox_SelectedItem(Options_Provider);
        } 
    } 
}
