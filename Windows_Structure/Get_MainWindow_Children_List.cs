using System;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Gets list of children windows of given MainWindow.
        /// </summary>
        public static MainWindow_Children_List Get_MainWindow_Children_List(IMainWindow mainWindow)
        {
            foreach (MainWindow_Children_List Children_List in MainWindows_List)
            {
                if (Children_List.This_MainWindow == mainWindow)
                    return Children_List;
            }

            return new MainWindow_Children_List();
        }
    }
}
