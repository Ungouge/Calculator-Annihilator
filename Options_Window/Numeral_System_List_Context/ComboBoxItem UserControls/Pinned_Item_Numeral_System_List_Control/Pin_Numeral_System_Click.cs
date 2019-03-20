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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common_Library;

namespace Options_Window
{
    partial class Pinned_Item_Numeral_System_List_Control
    {
        internal override void Pin_Numeral_System_Click(object sender, RoutedEventArgs e)
        {
            (OptionsWindow.Numeral_System_List_ComboBox.DataContext as Numeral_System_List_Context).Unpin_Numeral_System(this.Numeral_System_Code);
        }
    }
}
