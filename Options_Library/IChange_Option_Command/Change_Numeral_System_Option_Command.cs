﻿using System;

namespace Options_Library
{
    /// <summary>
    /// Changes numeral system in Options class.
    /// </summary>
    public class Change_Numeral_System_Option_Command : IChange_Option_Command
    {
        private readonly sbyte numeral_System_To_Change;

        /// <summary>
        /// Constructs new command for changing numeral system in Options class.
        /// </summary>
        public Change_Numeral_System_Option_Command(sbyte _numeral_System_To_Change)
        {
            numeral_System_To_Change = _numeral_System_To_Change;
        }

        /// <summary>
        /// Change numeral system option in given Options class
        /// </summary>
        public void Change_Option(ISet_Options options)
        {
            options.Set_Numeral_System(numeral_System_To_Change);
        }
    }
}
