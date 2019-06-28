using System;
using Options_Library;

namespace Options_Window
{
    partial class OptionsWindow

    {
        public void Add_New_Comma_Type_Option_Command(string[] Comma_Types)
        {
            Remove_Obsolete_Command<Add_New_Comma_Type_Option_Command>();

            Option_Change_Command_List.Add(new Add_New_Comma_Type_Option_Command(Comma_Types));
        }
    }
}
