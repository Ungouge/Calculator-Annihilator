using System;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Adds given MainWindow to structure manager MainWindow list.
        /// </summary>
        public static void Add_MainWindow(IMainWindow mainWindow)
        {
            if (MainWindow_Root == null)
                MainWindow_Root = mainWindow;

            MainWindows_List.Add(new MainWindow_Children_List (mainWindow));
        }
    }
}
