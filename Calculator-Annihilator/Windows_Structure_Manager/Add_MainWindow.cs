using System;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Adds given MainWindow to structure manager MainWindow list.
        /// </summary>
        static void Add_MainWindow(MainWindow mainWindow)
        {
            MainWindows_List.Add(new MainWindow_Children_List (mainWindow));
        }
    }
}
