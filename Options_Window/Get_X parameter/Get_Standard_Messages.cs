using System;
using Common_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        public IStandard_Messages_Translate Get_Standard_Messages
        {
            get
            {
                return Options_Provider.Get_Standard_Messages_Translate;
            }
        }
    }
}
