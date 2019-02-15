using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        /// <summary>
        /// Gets list of children windows of given MainWindow.
        /// </summary>
        static internal List<MainWindow> Get_MainWindows_List
        {
            get
            {
                List<MainWindow> mainWindows_List = new List<MainWindow>();

                foreach (MainWindow_Children_List Children_List in MainWindows_List)
                {
                    if (Children_List.This_MainWindow != null)
                        mainWindows_List.Add(Children_List.This_MainWindow);
                }

                return mainWindows_List;
            }
        }
    }
}
