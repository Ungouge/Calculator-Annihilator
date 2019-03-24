using System;
using Common_Library;

namespace Options_Library
{
    /// <summary>
    /// Changes font size type in Options class.
    /// </summary>
    public class Change_Font_Size_Option_Command : IChange_Option_Command
    {
        private readonly Font_Size_Type Font_Size_To_Change;

        /// <summary>
        /// Constructs new command for changing font size type in Options class.
        /// </summary>
        public Change_Font_Size_Option_Command(Font_Size_Type language_To_Change)
        {
            Font_Size_To_Change = language_To_Change;
        }

        /// <summary>
        /// Change font size type option in given Options class
        /// </summary>
        public void Change_Option(ISet_Options options)
        {
            options.Set_Font_Size_Type(Font_Size_To_Change);
        }
    }
}
