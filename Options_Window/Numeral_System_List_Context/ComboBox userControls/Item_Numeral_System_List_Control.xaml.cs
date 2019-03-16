using Common_Library;
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
    /// Interaction logic for Item_Numeral_System_List_Control.xaml
    /// </summary>
    public partial class Item_Numeral_System_List_Control : Numeral_System_List_Item
    {
        public Item_Numeral_System_List_Control(OWXYZ _OptionsWindow, sbyte numeral_System_Code)
        {
            Numeral_System_Code = numeral_System_Code;

            Content_Text = Numeral_System.Numeral_System_Dictionary_Name( numeral_System_Code,
                _OptionsWindow.Options.Standard_Messages);

            OWXYZ.Bindable_Resources Bindable_Resources = _OptionsWindow._Bindable_Resources;

            Image_Width = Bindable_Resources.ComboBox_List_Image_Height;

            Text_Width = Bindable_Resources.ComboBox_Element_Width - Image_Width;

            InitializeComponent();
        }

        public override string Pin_Image_Uri
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Clear.png";
            }
        }

        public override bool Is_Enabled
        {
            get
            {
                return true;
            }
        }

        private void Pin_Numeral_System_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
