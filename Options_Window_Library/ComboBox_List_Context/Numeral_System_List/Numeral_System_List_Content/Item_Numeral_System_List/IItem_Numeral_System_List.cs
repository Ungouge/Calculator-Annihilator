using System;
using System.Windows.Input;

namespace Options_Window_Library
{
    public interface IItem_Numeral_System_List: INumeral_System_List_Content
    {
        sbyte Numeral_System_Code { get; }

        string Pin_Image_Uri { get; }

        ICommand Numeral_System_Item_Button_Click { get; }
    }
}
