using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    public partial class Options_Window : Window
    {
        partial class Bindable_Resources
        {
            public string Language { get; set; }

            private void Set_General_Options_Texts()
            {
                Language = Options_Window.Paretnt_MainWindow.Standard_Messages.Translate("Language");
            }
        }
    }
}
