namespace Options_Window_Library
{
    public interface IFont_Size_List_Item: IComboBox_Item_Base
    {
        string Font_Size_Name { get; }

        string Font_Size_Symbol_Uri { get; }
    }
}