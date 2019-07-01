using System;

namespace Options_Window_Library
{
    public interface INumeral_System_List_Content: IComboBox_Item_Base
    {
        string Content_Text { get; }

        bool Is_Enabled { get; }
    }
}
