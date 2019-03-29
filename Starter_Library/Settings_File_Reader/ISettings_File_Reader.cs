using Options_Library;

namespace Starter_Library
{
    public interface ISettings_File_Reader
    {
        IOptions_Storage Get_Options_Storage { get; }
    }
}