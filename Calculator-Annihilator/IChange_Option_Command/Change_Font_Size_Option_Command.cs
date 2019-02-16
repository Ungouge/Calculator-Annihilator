using System;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Changes language in Options class.
    /// </summary>
    internal class Change_Font_Size_Option_Command : IChange_Option_Command
    {
        private readonly Font_Size_Type Font_Size_To_Change;

        /// <summary>
        /// Constructs new command for changing language in Options class.
        /// </summary>
        internal Change_Font_Size_Option_Command(Font_Size_Type language_To_Change)
        {
            Font_Size_To_Change = language_To_Change;
        }

        /// <summary>
        /// Change font size type option in given Options class
        /// </summary>
        public void Change_Option(Options options)
        {
            options.Set_Font_Size_Type(Font_Size_To_Change);
        }
    }
}
