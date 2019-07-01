namespace Options_Window_Library
{
    public interface ILangauge_List_Items: IComboBox_Item_Base
    {
        string Language_Flag_Uri { get; }

        string Language_Name { get; }
    }
}