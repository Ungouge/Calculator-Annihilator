using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Class to bind MainWindow to list of children windows.
        /// </summary>
        internal partial class MainWindow_Children_List
        {
            internal MainWindow This_MainWindow { get; private set; }

            internal List<IMainWindow_Children> This_Children_List { get; private set; }

            /// <summary>
            /// Construct new MainWindow_Children_List with empty children list.
            /// </summary>
            public MainWindow_Children_List(MainWindow mainWindow)
            {
                This_MainWindow = mainWindow;

                This_Children_List = new List<IMainWindow_Children>();
            }
        }
    }
}