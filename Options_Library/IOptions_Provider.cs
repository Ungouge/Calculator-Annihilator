using System;
using Common_Library;

namespace Options_Library
{
    public interface IOptions_Provider : IOptions_Storage, ISet_Options
    {
        IStandard_Messages_Translate Get_Standard_Messages_Translate { get; }
    }
}
