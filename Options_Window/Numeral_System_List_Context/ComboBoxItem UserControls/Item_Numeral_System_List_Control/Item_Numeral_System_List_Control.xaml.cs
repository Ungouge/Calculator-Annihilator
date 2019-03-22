using Common_Library;
using System;
using IOptions_Window;

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for Item_Numeral_System_List_Control.xaml
    /// </summary>
    public partial class Item_Numeral_System_List_Control : Numeral_System_List_Item
    {
        internal IOptionsWindow_Parameters OptionsWindow;

        public Item_Numeral_System_List_Control(OWXYZ _OptionsWindow, sbyte numeral_System_Code)
        {
            OptionsWindow = _OptionsWindow;

            Numeral_System_Code = numeral_System_Code;

            Content_Text = Numeral_System.Numeral_System_Dictionary_Name( Numeral_System_Code,
                OptionsWindow.Get_Standard_Messages);

            OWXYZ.Bindable_Resources Bindable_Resources = OptionsWindow._Bindable_Resources;

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
    }
}
