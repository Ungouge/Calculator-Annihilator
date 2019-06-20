using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Bindable_Resources 
    {
        protected override void Set_Window_Size()
        {
            switch (Font_Size_Type)
            {
                case Font_Size_Type.Small:
                    Window_Height = 424;

                    Window_Width = 436;

                    ComboBox_ToggleButton_Arrow_Width = 12;

                    break;
                case Font_Size_Type.Normal:
                    Window_Height = 424;

                    Window_Width = 436;

                    ComboBox_ToggleButton_Arrow_Width = 18;

                    break;
                case Font_Size_Type.Big:
                    Window_Height = 424;

                    Window_Width = 436;

                    ComboBox_ToggleButton_Arrow_Width = 24;

                    break;
                case Font_Size_Type.Hight_Contrast:
                    Window_Height = 600;

                    Window_Width = 800;

                    ComboBox_ToggleButton_Arrow_Width = 48;

                    break;
                default:
                    goto case Font_Size_Type.Normal;
            }
        }

    }
}