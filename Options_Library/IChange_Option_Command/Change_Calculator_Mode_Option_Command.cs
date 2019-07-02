using System;
using Common_Library;

namespace Options_Library
{
    /// <summary>
    /// Changes font size type in Options class.
    /// </summary>
    public class Change_Calculator_Mode_Option_Command : IChange_Option_Command
    {
        private readonly Calculator_Mode Calculator_Mode_To_Change;

        /// <summary>
        /// Constructs new command for changing font size type in Options class.
        /// </summary>
        public Change_Calculator_Mode_Option_Command(Calculator_Mode _Calculator_Mode_To_Change)
        {
            Calculator_Mode_To_Change = _Calculator_Mode_To_Change;
        }

        /// <summary>
        /// Change font size type option in given Options class
        /// </summary>
        public void Change_Option(ISet_Options options)
        {
            options.Set_Calculator_Mode(Calculator_Mode_To_Change);
        }
    }
}