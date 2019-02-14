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
    partial class Options_Window : Window, IMainWindow_Children
    {
        internal Bindable_Resources _Bindable_Resources;

        public MainWindow Parent_MainWindow { get; set; }

        private Options Options;

        List<Action<MainWindow>> Options_Changed_List;
    }
}
