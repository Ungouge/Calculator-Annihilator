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
            GUI_Bindable_Resources.Push_Recalculations();
        }
        public void Window_State_Changed(object sender, EventArgs e)
        {
            GUI_Bindable_Resources.Push_Recalculations();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            GUI_Bindable_Resources.Push_Recalculations();
        }

        private void WorkSpace_TextChanged(object sender, TextChangedEventArgs e)
        {
            GUI_Bindable_Resources.On_Property_Change("WorkSpace_FontSize");
        }

        private void ResultSpace_TextChanged(object sender, TextChangedEventArgs e)
        {
            GUI_Bindable_Resources.On_Property_Change("ResultSpace_FontSize");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // check settings file is written when it will be written
        }
    }
}
