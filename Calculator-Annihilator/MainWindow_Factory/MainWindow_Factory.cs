using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Options_Library;

namespace Calculator_Annihilator
{
    public partial class MainWindow_Factory
    {
        IOptions_Storage Options_Storage;

        public MainWindow_Factory(IOptions_Storage _Options_Storage)
        {
            Options_Storage = _Options_Storage;
        }
    }
}
