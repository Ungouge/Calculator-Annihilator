using System;
using System.Collections.Generic;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Removes given MainWindow out off structer manager.
        /// </summary>
        static internal List<IMainWindow_Children> Remove_MainWindow(IMainWindow mainWindow)
        {
            MainWindow_Children_List MainWindow_Children_List = Get_MainWindow_Children_List(mainWindow);

            List<IMainWindow_Children> Children_List = MainWindow_Children_List.This_Children_List;

            MainWindows_List.Remove(MainWindow_Children_List);

            return Children_List;
        }
    }
}
