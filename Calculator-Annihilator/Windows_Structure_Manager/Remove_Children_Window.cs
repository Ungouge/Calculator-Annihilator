using System;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Removes given children window out of structure manager.
        /// </summary>
        static void Remove_Children_Window(IMainWindow_Children Children_Window)
        {
            if (Children_Window is Options_Window options_Window)
            {
                Options_Windows_List.Remove(options_Window);
            }

            Remove_children(Children_Window);
        }
    }
}
