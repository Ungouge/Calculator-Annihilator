using Common_Library;

namespace Options_Library
{
    public interface IGet_MainWindow_Options: IMainWindow
    {
        IOptions_Provider Get_Options { get; }
    }
}
