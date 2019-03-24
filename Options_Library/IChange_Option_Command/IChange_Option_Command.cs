using System;

namespace Options_Library
{
    /// <summary>
    /// Provides Machanism to change option in Options class.
    /// </summary>
    public interface IChange_Option_Command
    {
        void Change_Option(ISet_Options options);
    }
}
