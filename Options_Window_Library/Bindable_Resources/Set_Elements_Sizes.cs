using System;
using AnnihilatorWindowBase;
using Common_Library;

namespace Options_Window_Library
{
    public partial class Bindable_Resources : Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_Elements_Sizes()
        {
            switch (Font_Size_Type)
            {
                case Font_Size_Type.Small:

                    ComboBox_ToggleButton_Arrow_Width = 12;

                    ComboBox_Element_Width = 80;

                    TabItem_Grid_Height = 90;

                    break;
                case Font_Size_Type.Normal:

                    ComboBox_ToggleButton_Arrow_Width = 18;

                    ComboBox_Element_Width = 120;

                    TabItem_Grid_Height = 135;

                    break;
                case Font_Size_Type.Big:

                    ComboBox_ToggleButton_Arrow_Width = 24;

                    ComboBox_Element_Width = 160;

                    TabItem_Grid_Height = 180;

                    break;
                case Font_Size_Type.Hight_Contrast:

                    ComboBox_ToggleButton_Arrow_Width = 48;

                    ComboBox_Element_Width = 320;

                    TabItem_Grid_Height = 360;

                    break;
                default:
                    goto case Font_Size_Type.Normal;
            }
        }

    }
}