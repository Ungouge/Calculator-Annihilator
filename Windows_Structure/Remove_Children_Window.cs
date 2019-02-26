using System;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Removes given children window out of structure manager.
        /// </summary>
        static void Remove_Children_Window(IMainWindow_Children Children_Window)
        {
            if (Children_Window is IOptionsWindow options_Window)
            {
                Options_Windows_List.Remove(options_Window);
            }

            Remove_children(Children_Window);
        }
    }
}
