using System;

namespace Options_Window
{
    partial class Numeral_System_List_Content_Factory
    {
        internal Label_Numeral_System_List_Control Get_Label(double comboBox_Element_Width)
        {
            return new Label_Numeral_System_List_Control(comboBox_Element_Width, label_Text);
        }
    }
}