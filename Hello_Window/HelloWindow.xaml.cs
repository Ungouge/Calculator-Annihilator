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
using Options_Library;
using StartUpWindowBase;

namespace Hello_Window
{
    /// <summary>
    /// Interaction logic for HelloWindow.xaml
    /// </summary>
    public partial class HelloWindow : Start_Up_Window_Base
    {
        public IOptions_Provider Startup_Options;

        public HelloWindow()
        {
            InitializeComponent();
        }

        protected override string[] Styled_Elements_List { get; } = new string[] { };
        protected override void Set_Element_Base_Style(){}
        protected override void Set_Element_Default_Style() { }
        protected override void Set_Styles() { }
    }
}
