using System;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class Options_Window : Window
    {
        /// <summary>
        /// Executes every change option command enlisten in command list in given options class.
        /// </summary>
        private void Apply_Option_Change(Options options)
        {
            foreach (IChange_Option_Command Change_Option_Command in Option_Change_Command_List)
            {
                Change_Option_Command.Change_Option(options);
            }
        }
    }
}
