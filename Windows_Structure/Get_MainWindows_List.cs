using System;
using System.Collections.Generic;
using Common_Library;

namespace Windows_Structure
{
    static partial class Windows_Manager
    {
        /// <summary>
        /// Gets list of children windows of given MainWindow.
        /// </summary>
        public static List<IMainWindow> Get_MainWindows_List
        {
            get
            {
                List<IMainWindow> mainWindows_List = new List<IMainWindow>();

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
