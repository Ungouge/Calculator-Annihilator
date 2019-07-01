using System;
using System.Collections.Generic;
using Common_Library;

namespace Options_Window_Library
{
    partial class Langauge_List_Context
    {
        /// <summary>
        /// Sets list of Language_List_Content.
        /// </summary>
        private List<ILangauge_List_Items> Set_Languge_List_Items(IStandard_Messages_Translate Standard_Messages)
        {
            List<ILangauge_List_Items> Output_Items_List = new List<ILangauge_List_Items>();

            foreach (Languages language in (Languages[]) Enum.GetValues(typeof(Languages)))
            {
                Output_Items_List.Add( new Langauge_List_Items(Standard_Messages, language));
            }

            return Output_Items_List;
        }
    }
}