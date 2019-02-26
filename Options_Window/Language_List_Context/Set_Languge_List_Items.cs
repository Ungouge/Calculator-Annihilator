using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        partial class Langauge_List_Context
        {
            private List<Langauge_List_Items> Set_Languge_List_Items()
            {
                List<Langauge_List_Items> Output_Items_List = new List<Langauge_List_Items>();

                foreach (Languages language in (Languages[]) Enum.GetValues(typeof(Languages)))
                {
                    Output_Items_List.Add( new Langauge_List_Items(OptionsWindow, language));
                }

                return Output_Items_List;
            }
        }
    }
}
