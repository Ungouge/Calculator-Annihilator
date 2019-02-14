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
        public partial class Bindable_Resources
        {
            internal void Set_Text_Bindables(Standard_Messages standard_Messages)
            {
                Set_General_Options_Texts(standard_Messages);

                Set_Buttons_Texts(standard_Messages);

                Set_Language_ComboBox_Texts(standard_Messages);
            }
        }
    }
}
