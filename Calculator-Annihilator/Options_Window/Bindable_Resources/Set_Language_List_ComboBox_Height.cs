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
            public double Set_Language_List_ComboBox_Height()//Options_Window _Options_Window)
            {
                //Formatted_Text_Getter formatted_Text =
                //    new Formatted_Text_Getter(_Options_Window.Language_List_TextBlock,
                //    _Options_Window.Language_List_TextBlock.FontSize);
                return 15e0;
            }
        }
    }
}
