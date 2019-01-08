using System;

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
