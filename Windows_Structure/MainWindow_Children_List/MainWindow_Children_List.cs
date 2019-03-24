using System;
using System.Collections.Generic;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Class to bind MainWindow to list of children windows.
        /// </summary>
        partial class MainWindow_Children_List
        {
            internal IMainWindow This_MainWindow { get; private set; }

            public List<IMainWindow_Children> This_Children_List { get; private set; }

            /// <summary>
            /// Construct new MainWindow_Children_List with empty children list.
            /// </summary>
            public MainWindow_Children_List(IMainWindow mainWindow)
            {
                This_MainWindow = mainWindow;

                This_Children_List = new List<IMainWindow_Children>();
            }
        }
    }
}