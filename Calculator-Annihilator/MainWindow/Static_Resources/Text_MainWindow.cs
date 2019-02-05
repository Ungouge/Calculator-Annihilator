using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Static_Resources 
        {
            string Title;

            protected internal void Set_Texts(MainWindow MainWindow)
            {
                Title = MainWindow.Standard_Messages.Translate("Title");
            }
        }
    }
}
