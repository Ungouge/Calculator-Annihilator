﻿using System;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Adds children window to list binded to its parent in structure manager. 
        /// </summary>
        static internal void Add_Children_Window(IMainWindow_Children children_Window)
        {
            Add_Children(children_Window);

            if( children_Window is Options_Window options_Window)
            {
                Options_Windows_List.Add(options_Window);
            }

        }
    }
}
