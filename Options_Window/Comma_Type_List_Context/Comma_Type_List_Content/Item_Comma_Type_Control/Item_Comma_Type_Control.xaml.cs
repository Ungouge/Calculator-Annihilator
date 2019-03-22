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
    /// Interaction logic for Item_Comma_Type_Control.xaml
    /// </summary>
    public partial class Item_Comma_Type_Control : Comma_Type_List_Content
    {
        public Item_Comma_Type_Control(OWXYZ _OptionsWindow, string content_Text)
        {
            Content_Text = content_Text;

            OWXYZ.Bindable_Resources Bindable_Resources = _OptionsWindow._Bindable_Resources;

            Text_Width = Bindable_Resources.ComboBox_Element_Width;

            InitializeComponent();
        }

        public override bool Is_Selectable
        {
            get
            {
                return true;
            }
        }
    }
}