using System;
using System.Collections.Generic;
using System.Windows;
using Options_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        public List<INumeral_System_List_Content> Numeral_System_List_Items_List
        {
            get
            {
                List<INumeral_System_List_Content> Output_Items_List = new List<INumeral_System_List_Content>();

                if (Pinned_Numeral_Systems.Get_Numeral_Systems_Codes.Length > 0)
                {
                    Output_Items_List.Add(Factory.Get_Pinned_Systems_Label_Control);

                    Output_Items_List.AddRange(Pinned_Items_List);
                }

                Output_Items_List.Add(Factory.Get_All_Systems_Label_Control);

                Output_Items_List.AddRange(Items_List);

                return Output_Items_List;
            }
        }
    }
}
