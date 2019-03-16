using System;

namespace Options_Window
{
    class Pinned_Item_Numeral_System_List_Control: Item_Numeral_System_List_Control
    {
        public Pinned_Item_Numeral_System_List_Control(OWXYZ _OptionsWindow, sbyte numeral_System_Code) 
            : base(_OptionsWindow, numeral_System_Code)
        {}

        public override string Pin_Image_Uri
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Pined.png";
            }
        }
    }
}
