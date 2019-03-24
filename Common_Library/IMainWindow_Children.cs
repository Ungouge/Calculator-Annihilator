namespace Common_Library
{
    public interface IMainWindow_Children
    {
        IMainWindow Parent_MainWindow { get; }

        void Push_Set_Text(Standard_Messages standard_Messages);
    }
}
