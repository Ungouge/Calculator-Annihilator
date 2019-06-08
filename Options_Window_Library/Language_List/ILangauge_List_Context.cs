using System;
using System.Collections.Generic;

namespace Options_Window_Library
{
    public interface ILangauge_List_Context
    {
        List<Langauge_List_Items> Langauge_List_Items_List { get;}

        Langauge_List_Items Language_List_ComboBox_SelectedItem { get; set; }
    }
}
