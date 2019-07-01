namespace Options_Window_Library
{
    public interface IComma_Type_List_Item: IComboBox_Item_Base
    {
        string Content_Text { get; }

        bool Is_Selectable { get; }
    }
}