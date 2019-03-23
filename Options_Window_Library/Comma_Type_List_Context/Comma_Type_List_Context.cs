using System;
using System.Collections.Generic;
using IOptions_Window;

namespace Options_Window_Library
{
    /// <summary>
    /// Provides data context for Comma_Type_List_CombBox.
    /// </summary>
    public partial class Comma_Type_List_Context
    {
        IOptionsWindow_Parameters OptionsWindow;

        Commas_Type_Item_Factory Factory;

        private string[] Commas_Type;

        public Comma_Type_List_Content Comma_Type_List_ComboBox_SelectedItem { get; set; }

        public List<Comma_Type_List_Content> Comma_Type_Items_List { get; private set; }

        /// <summary>
        /// Constructs new Comma_Type_List_Context for given OptionsWindow.
        /// </summary>
        public Comma_Type_List_Context(IOptionsWindow_Parameters _OptionsWindow, Bindable_Resources _Bindable_Resources)
        {
            OptionsWindow = _OptionsWindow;

            Commas_Type = OptionsWindow.Get_Options_Provider.Commas_Type_Array;

            Factory = new Commas_Type_Item_Factory(_Bindable_Resources, OptionsWindow.Get_Standard_Messages);

            Comma_Type_Items_List = Set_Comma_Type_Items_List();
        } 
    }
}
