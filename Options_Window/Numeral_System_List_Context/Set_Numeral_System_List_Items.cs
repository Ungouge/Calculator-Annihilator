using System;
using System.Collections.Generic;
using Common_Library;
using Options_Library;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        private List<Numeral_System_List_Content> Set_Numeral_System_List_Items()
        {
            List<Numeral_System_List_Content> Output_Items_List = new List<Numeral_System_List_Content>();

            Numeral_System_List_Content_Factory Factory = new Numeral_System_List_Content_Factory(
                OptionsWindow.Options.Standard_Messages);
            
            Output_Items_List.Add(Factory.Get_Label(OptionsWindow._Bindable_Resources.ComboBox_Element_Width));

            foreach (sbyte pinned_Numeral_System in Pinned_Numeral_Systems.Get_Numeral_Systems_Codes)
            {
                Output_Items_List.Add(Factory.Get_Item(OptionsWindow, pinned_Numeral_System));
            }

            Factory = new Numeral_System_List_Pinned_Content_Factory(OptionsWindow.Options.Standard_Messages);

            Output_Items_List.Add(Factory.Get_Label(OptionsWindow._Bindable_Resources.ComboBox_Element_Width));

            foreach (Numeral_System_Group numeral_Systems_Group in Used_Numeral_Systems.Numeral_Systems)
            {
                for (sbyte numeral_System = numeral_Systems_Group.starting_Code;
                    numeral_System <= numeral_Systems_Group.finale_Code; numeral_System++)
                {
                    Output_Items_List.Add(Factory.Get_Item(OptionsWindow, numeral_System));
                }
            }

            return Output_Items_List;
        }
    }
}
