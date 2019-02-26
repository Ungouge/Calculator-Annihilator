using System;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Checks does given MainWindow has any children Windows.
        /// </summary>
        static internal bool Is_Children_Windows (IMainWindow mainWindow)
        {
            MainWindow_Children_List mainWindow_Children_List = Get_MainWindow_Children_List(mainWindow);

            return mainWindow_Children_List.This_Children_List.Count == 0;
        }
    }
}
