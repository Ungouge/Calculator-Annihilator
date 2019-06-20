using System;
using System.Windows;
using Common_Library;
using Options_Library;

namespace AnnihilatorWindowBase
{
    abstract public partial class Annihilator_Window_Base : Window
    {
        protected virtual IOptions_Provider Options_Provider { get; set; }

        public IOptions_Storage Get_Options_Storage
        {
            get
            {
                return Options_Provider;
            }
        }

        public ISet_Options Get_Set_Options
        {
            get
            {
                return Options_Provider;
            }
        }
    }
}
