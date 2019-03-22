using Common_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Options_Window
{
    internal partial class Comma_Type_List_Context
    {
        OWXYZ _OptionsWindow;

        Commas_Type_Item_Factory Factory;

        private string[] Commas_Type;

        public Comma_Type_List_Content Comma_Type_List_ComboBox_SelectedItem { get; set; }

        public List<Comma_Type_List_Content> Comma_Type_Items_List { get; private set; }

        public Comma_Type_List_Context(OWXYZ OptionsWindow)
        {
            _OptionsWindow = OptionsWindow;

            Commas_Type = _OptionsWindow.Options.Commas_Type_Array;

            Factory = new Commas_Type_Item_Factory(OptionsWindow);

            Comma_Type_Items_List = Set_Comma_Type_Items_List();
        } 
    }
}
