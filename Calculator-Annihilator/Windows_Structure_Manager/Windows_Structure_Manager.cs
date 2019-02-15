using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Manages structure of Windows in application.
    /// </summary>
    static internal partial class Windows_Structure_Manager
    {
        static MainWindow MainWindow_Root;

        static List<MainWindow_Children_List> MainWindows_List = new List<MainWindow_Children_List>();

        static List<Options_Window> Options_Windows_List = new List<Options_Window>();
    }
}
