using System;

namespace Options_Window_Library
{
    internal partial class Pinned_Item_Numeral_System_List : Item_Numeral_System_List, IPinned_Item_Numeral_System_List
    {
        internal Pinned_Item_Numeral_System_List(Numeral_System_List_Context _Numeral_System_List_Context, sbyte numeral_System_Code)
            : base(_Numeral_System_List_Context, numeral_System_Code)
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
