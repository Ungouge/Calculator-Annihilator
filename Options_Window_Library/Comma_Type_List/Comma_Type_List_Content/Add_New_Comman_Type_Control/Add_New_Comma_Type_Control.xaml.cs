using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Interaction logic for Add_New_Comma_Type_Control.xaml
    /// </summary>
    public partial class Add_New_Comma_Type_Control : Comma_Type_List_Content
    {
        public double Button_Width { get; private set; }

        public string New_Comma { get; set; }

        public double Image_Width { get; private set; }

        Comma_Type_List_Context Comma_Type_List_Context;

        internal Add_New_Comma_Type_Control(Comma_Type_List_Context _Comma_Type_List_Context, Bindable_Resources Bindable_Resources, IStandard_Messages_Translate Standard_Messages)
        {
            Comma_Type_List_Context = _Comma_Type_List_Context;

            Content_Text = Standard_Messages.Translate("Add_New_Comma");

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
