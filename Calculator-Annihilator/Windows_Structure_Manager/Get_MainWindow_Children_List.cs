using System;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Gets list of children windows of given MainWindow.
        /// </summary>
        static internal MainWindow_Children_List Get_MainWindow_Children_List(MainWindow mainWindow)
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
