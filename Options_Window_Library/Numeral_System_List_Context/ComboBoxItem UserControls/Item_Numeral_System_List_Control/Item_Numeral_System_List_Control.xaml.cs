using Common_Library;
using System;

namespace Options_Window_Library
{
    /// <summary>
    /// Interaction logic for Item_Numeral_System_List_Control.xaml
    /// </summary>
    public partial class Item_Numeral_System_List_Control : Numeral_System_List_Item
    {
        protected Numeral_System_List_Context Numeral_System_List_Context;

        internal Item_Numeral_System_List_Control(Numeral_System_List_Context _Numeral_System_List_Context,
            Bindable_Resources _Bindable_Resources, sbyte numeral_System_Code)
        {
            Numeral_System_List_Context = _Numeral_System_List_Context;

            Numeral_System_Code = numeral_System_Code;

            Content_Text = Numeral_System.Numeral_System_Dictionary_Name( Numeral_System_Code,
                Numeral_System_List_Context.Standard_Messages);

            Bindable_Resources Bindable_Resources = _Bindable_Resources;

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
