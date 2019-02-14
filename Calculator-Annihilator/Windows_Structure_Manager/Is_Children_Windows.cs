using System;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Checks does given MainWindow has any children Windows.
        /// </summary>
        static internal bool Is_Children_Windows (MainWindow mainWindow)
        {
            MainWindow_Children_List mainWindow_Children_List = Get_MainWindow_Children_List(mainWindow);

            return mainWindow_Children_List.This_Children_List.Count == 0;
        }
    }
}
