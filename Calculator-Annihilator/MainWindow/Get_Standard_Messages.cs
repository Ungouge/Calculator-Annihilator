using System;
using Common_Library;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        public IStandard_Messages_Translate Get_Standard_Messages
        {
            get
            {
                return Options.Standard_Messages;
            }
        }
    }
}
