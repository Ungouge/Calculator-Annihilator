using System;

namespace Options_Window_Library
{
    /// <summary>
    /// Interaction logic for Item_Comma_Type_Control.xaml
    /// </summary>
    public partial class Item_Comma_Type_Control : Comma_Type_List_Content
    {
        public Item_Comma_Type_Control(Bindable_Resources Bindable_Resources, string content_Text)
        {
            Content_Text = content_Text;

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