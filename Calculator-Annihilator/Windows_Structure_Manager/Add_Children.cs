using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Adds children window to list binded to its parent. 
        /// </summary>
        static private void Add_Children(IMainWindow_Children children_Window)
        {
            foreach (MainWindow_Children_List Children_List in MainWindows_List)
            {
                if (Children_List.This_MainWindow == children_Window.Parent_MainWindow)
                    Children_List.This_Children_List.Add(children_Window);
            }
        }
    }
}
