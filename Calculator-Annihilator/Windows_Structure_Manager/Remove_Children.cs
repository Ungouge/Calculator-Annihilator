using System;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Removes given children window out of binding to MainWindow.
        /// </summary>
        private static void Remove_children(IMainWindow_Children Children_Window)
        {
            foreach (MainWindow_Children_List Children_List in MainWindows_List)
            {
                foreach (IMainWindow_Children Children in Children_List.This_Children_List)
                {
                    if (Children == Children_Window)
                    {
                        Children_List.This_Children_List.Remove(Children);

                        return;
                    }
                }
            }
        }
    }
}
