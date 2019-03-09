using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        private List<INumeral_System_List_Content> Set_Numeral_System_List_Items()
        {
            List<INumeral_System_List_Content> Output_Items_List = new List<INumeral_System_List_Content>();

            Output_Items_List.Add(new Label_Pinned_Numeral_System_List_Item( OptionsWindow));
            
            foreach (sbyte numeral_Systems in OptionsWindow.Options.Pined_Numeral_Systems)
            {
                Output_Items_List.Add(new Pined_Numeral_System_List_Item(OptionsWindow, numeral_Systems));
            }

            Output_Items_List.Add(new Label_All_Numeral_System_List_Item(OptionsWindow));

            foreach (Numeral_System_Group numeral_Systems_Group in Used_Numeral_Systems.Numeral_Systems)
            {
                for (sbyte numeral_System = numeral_Systems_Group.starting_Code;
                    numeral_System <= numeral_Systems_Group.finale_Code; numeral_System++)
                {
                    Output_Items_List.Add(new Numeral_System_List_Item(OptionsWindow, numeral_System));
                }
            }

            return Output_Items_List;
        }
    }
}
