using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator_Annihilator
{
    partial class Options_Window
    {
        /// <summary>
        /// Removes from command list command in given type.
        /// </summary>
        /// <typeparam name="T">Only "IChange_Option_Command" Type</typeparam>
        private void Remove_Obsolete_Command<T>()
        {
            foreach (T obsolete_Command in Option_Change_Command_List)
            {
                Option_Change_Command_List.Remove((IChange_Option_Command)obsolete_Command);

                return;
            }
        }
    }
}
