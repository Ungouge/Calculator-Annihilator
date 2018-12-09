using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    partial class MainWindow_Dynamic_Parameters
    {
        public double ResultSpace_FontSize
        {
            get
            {
                Font_To_TextBox_Macher Macher = new Font_To_TextBox_Macher(Current_Window.ResultSpace);

                return Macher.Match_Font_To_TextBox();
            }
        }

    }
}
