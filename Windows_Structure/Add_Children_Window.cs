using System;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Adds children window to list binded to its parent in structure manager. 
        /// </summary>
        static internal void Add_Children_Window(IMainWindow_Children children_Window)
        {
            Add_Children(children_Window);

            if( children_Window is IOptionsWindow options_Window)
            {
                Options_Windows_List.Add(options_Window);
            }

        }
    }
}
