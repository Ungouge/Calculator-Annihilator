using System;
using Common_Library;

namespace AnnihilatorWindowBase
{
    public abstract partial class Annihilator_Window_Bindable_Resources_Base
    {
        public Annihilator_Window_Bindable_Resources_Base(Font_Size_Type _Font_Size_Type)
        {
            Font_Size_Type = Font_Size_Type.Hight_Contrast;// _Font_Size_Type;

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
