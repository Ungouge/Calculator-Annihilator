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

namespace OptionsWindow
{
    partial class Options_Window
    {
        private Bindable_Resources _Bindable_Resources;

        private Number_Notation_List_Context _Number_Notation_List_Context;

        private Langauge_List_Context _Langauge_List_Context;

        private Font_Size_List_Context _Font_Size_List_Context;

        private Numeral_System_List_Context _Numeral_System_List_Context;

        public MainWindow Parent_MainWindow { get; set; }

        internal Options Options;

        List<IChange_Option_Command> Option_Change_Command_List;
    }
}
