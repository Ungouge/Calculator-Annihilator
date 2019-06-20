using System;
using Common_Library;

namespace AnnihilatorWindowBase
{
    partial class Annihilator_Window_Bindable_Resources_Base
    {
        private void Set_Font_Size_Type()
        {
            Pressed_Scale_Factor = 9e-1;

            switch (Font_Size_Type)
            {
                case Font_Size_Type.Small:
                    Set_Small_Font_Size_Type();
                    break;
                case Font_Size_Type.Normal:
                    Set_Normal_Font_Size_Type();
                    break;
                case Font_Size_Type.Big:
                    Set_Big_Font_Size_Type();
                    break;
                case Font_Size_Type.Hight_Contrast:
                    Set_High_Contrast_Font_Size_Type();
                    break;
                default:
                    goto case Font_Size_Type.Normal;
            }
        }
    }
}