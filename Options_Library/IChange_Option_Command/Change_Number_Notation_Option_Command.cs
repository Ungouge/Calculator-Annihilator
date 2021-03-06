﻿using System;
using Common_Library;

namespace Options_Library
{
    /// <summary>
    /// Changes number notation in Options class.
    /// </summary>
    public class Change_Number_Notation_Option_Command : IChange_Option_Command
    {
        private readonly Number_Notation Number_Notation_To_Change;

        /// <summary>
        /// Constructs new command for changing number notation in Options class.
        /// </summary>
        public Change_Number_Notation_Option_Command(Number_Notation number_Notation_To_Change)
        {
            Number_Notation_To_Change = number_Notation_To_Change;
        }

        /// <summary>
        /// Change number notation option in given Options class
        /// </summary>
        public void Change_Option(ISet_Options options)
        {
            options.Set_Number_Notation(Number_Notation_To_Change);
        }
    }
}
