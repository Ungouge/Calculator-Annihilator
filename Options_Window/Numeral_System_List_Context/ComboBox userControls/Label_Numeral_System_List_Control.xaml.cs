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

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for Label_Numeral_System_List_Control.xaml
    /// </summary>
    public partial class Label_Numeral_System_List_Control : Numeral_System_List_Content
    {
        public Label_Numeral_System_List_Control(OWXYZ.Bindable_Resources _Bindable_Resources, string text)
        {
            Content_Text = text;

            Text_Width = _Bindable_Resources.ComboBox_Element_Width;

            InitializeComponent();
        }

        public override bool Is_Enabled
        {
            get
            {
                return false;
            }
        }
    }
}
