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

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        private void Window_Size_Changed(object sender, SizeChangedEventArgs e)
        {
            GUI_Dynamic_Parameters.Push_Recalculations();
        }
        public void Window_State_Changed(object sender, EventArgs e)
        {
            GUI_Dynamic_Parameters.Push_Recalculations();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            GUI_Dynamic_Parameters.Push_Recalculations();
        }

        private void WorkSpace_TextChanged(object sender, TextChangedEventArgs e)
        {
            GUI_Dynamic_Parameters.OnPropertyChange("WorkSpace_FontSize");
        }

        private void ResultSpace_TextChanged(object sender, TextChangedEventArgs e)
        {
            GUI_Dynamic_Parameters.OnPropertyChange("ResultSpace_FontSize");
        }
    }
}
