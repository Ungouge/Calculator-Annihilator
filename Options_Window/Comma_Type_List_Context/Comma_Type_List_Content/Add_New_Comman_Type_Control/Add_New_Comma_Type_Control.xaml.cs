using System;
using IOptions_Window;

namespace Options_Window
{
    /// <summary>
    /// Interaction logic for Add_New_Comma_Type_Control.xaml
    /// </summary>
    public partial class Add_New_Comma_Type_Control : Comma_Type_List_Content
    {
        public double Button_Width { get; private set; }

        public string New_Comma { get; set; }

        public double Image_Width { get; private set; }

        private OWXYZ OptionsWindow;

        public Add_New_Comma_Type_Control(OWXYZ _OptionsWindow)
        {
            OptionsWindow = _OptionsWindow;

            Content_Text = OptionsWindow.Options.Standard_Messages.Translate("Add_New_Comma");

            OWXYZ.Bindable_Resources Bindable_Resources = OptionsWindow._Bindable_Resources;

            Image_Width = Bindable_Resources.ComboBox_List_Image_Height;

            Text_Width = Bindable_Resources.ComboBox_Element_Width - Image_Width;

            InitializeComponent();

            
        }

        public override bool Is_Selectable
        {
            get
            {
                return false;
            }
        }
    }
}
