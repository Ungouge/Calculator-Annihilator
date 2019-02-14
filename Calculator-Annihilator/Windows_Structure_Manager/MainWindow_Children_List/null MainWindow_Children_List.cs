using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    static partial class Windows_Structure_Manager
    {
        internal partial class MainWindow_Children_List
        {
            /// <summary>
            /// Construnct Null MainWindow_Children_List.
            /// </summary>
            public MainWindow_Children_List()
            {
                This_MainWindow = null; //Do need null MainWindow?

                This_Children_List = new List<IMainWindow_Children>();
            }
        }
    }
}