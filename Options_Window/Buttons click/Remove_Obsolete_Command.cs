using System;
using System.Collections.Generic;
using System.Linq;
using Options_Library;

namespace Options_Window
{
    partial class OptionsWindow
    {
        /// <summary>
        /// Removes from command list command in given type.
        /// </summary>
        /// <typeparam name="T">Only "IChange_Option_Command" Type</typeparam>
        private void Remove_Obsolete_Command<T>() where T: IChange_Option_Command
        {
            List<T> Obsolete_Commands_List = new List<T>();

            foreach (IChange_Option_Command Command in Option_Change_Command_List ?? Enumerable.Empty<IChange_Option_Command>())
                if (Command is T obsolete_Command)
                    Obsolete_Commands_List.Add(obsolete_Command);

            foreach (T obsolete_Command in Obsolete_Commands_List)
                    Option_Change_Command_List.Remove(obsolete_Command);
        }
    }
}
