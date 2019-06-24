using System;
using System.Windows.Input;
using Common_Library;

namespace Options_Window_Library
{
    internal partial class Item_Numeral_System_List: Numeral_System_List_Content, IItem_Numeral_System_List
    {
        public sbyte Numeral_System_Code { get; protected set; }

        protected readonly Numeral_System_List_Context Numeral_System_List_Context;

        internal Item_Numeral_System_List(Numeral_System_List_Context _Numeral_System_List_Context, sbyte numeral_System_Code)
        {
            Numeral_System_List_Context = _Numeral_System_List_Context;

            Numeral_System_Code = numeral_System_Code;

            Content_Text = Numeral_System.Numeral_System_Dictionary_Name(Numeral_System_Code, Numeral_System_List_Context.Standard_Messages);
        }

        public ICommand Numeral_System_Item_Button_Click
        {
            get
            {
                return new Item_Numeral_System_Button_Command(this);
            }
        }

        public virtual string Pin_Image_Uri
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Clear.png";
            }
        }

        public override bool Is_Enabled
        {
            get
            {
                return true;
            }
        }
    }
}
