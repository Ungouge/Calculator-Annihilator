using System;
using Common_Library;
using Options_Library;

namespace IOptions_Window
{
    public interface IOptionsWindow_Parameters
    {
        IStandard_Messages_Translate Get_Standard_Messages { get; }

        IOptions_Storage Get_Options_Provider { get; }

        void Add_New_Comma_Type_Option_Command(string[] Commas_Type);
    }
}
