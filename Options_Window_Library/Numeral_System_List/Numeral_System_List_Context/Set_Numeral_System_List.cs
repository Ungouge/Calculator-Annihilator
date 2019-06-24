using System;
using Common_Library;
using System.Collections.Generic;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        /// <summary>
        /// Sets list of Numeral_Systems.
        /// </summary>
        private List<IItem_Numeral_System_List> Set_Numeral_System_List()
        {
            List<IItem_Numeral_System_List> Output_Items_List = new List<IItem_Numeral_System_List>();

            foreach (Numeral_System_Group numeral_Systems_Group in Used_Numeral_Systems.Numeral_Systems)
            {
                for (sbyte numeral_System = numeral_Systems_Group.starting_Code;
                    numeral_System <= numeral_Systems_Group.finale_Code; numeral_System++)
                {
                    Output_Items_List.Add(Factory.Get_Item( numeral_System));
                }
            }

            return Output_Items_List;
        }
    }
}
