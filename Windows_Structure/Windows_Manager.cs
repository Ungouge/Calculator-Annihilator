using System;
using System.Collections.Generic;
using Common_Library;

namespace Windows_Structure
{
    /// <summary>
    /// Manages structure of Windows in application.
    /// </summary>
    public static partial class Windows_Manager
    {
        private static IMainWindow MainWindow_Root;

        static List<MainWindow_Children_List> MainWindows_List = new List<MainWindow_Children_List>();

        static List<IOptionsWindow_Show> Options_Windows_List = new List<IOptionsWindow_Show>();
    }
}
