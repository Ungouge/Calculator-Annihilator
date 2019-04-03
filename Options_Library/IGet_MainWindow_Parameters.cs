using System;
using Common_Library;

namespace Options_Library
{
    public interface IGet_MainWindow_Parameters: IMainWindow
    {
        IOptions_Provider Get_Options { get; }
    }
}
