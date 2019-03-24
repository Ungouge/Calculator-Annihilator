using System;

namespace Options_Window_Library
{
    internal partial class Pinned_Item_Numeral_System_List_Control: Item_Numeral_System_List_Control
    {
        internal Pinned_Item_Numeral_System_List_Control(Numeral_System_List_Context _Numeral_System_List_Context, Bindable_Resources _Bindable_Resources, sbyte numeral_System_Code)
            : base(_Numeral_System_List_Context, _Bindable_Resources, numeral_System_Code)
        { }

        public override string Pin_Image_Uri
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Pined.png";
            }
        }
    }
}
