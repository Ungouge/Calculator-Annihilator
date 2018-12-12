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
        /// <summary>
        /// Gets font size for work space.
        /// </summary>
        public double WorkSpace_FontSize // Called by name by MainWindow.WorkSpace_TextChanged()
        {
            get
            {
                Font_To_TextBox_Matcher Matcher = new Font_To_TextBox_Matcher(Current_Window.WorkSpace);

                return Matcher.Match_Font_To_TextBox();
            }
        }
    }
}