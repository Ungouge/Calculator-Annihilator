using System;
using Common_Library;

namespace Options_Library
{
    /// <summary>
    /// Changes language in Options class.
    /// </summary>
    public class Change_Comma_Type_Option_Command : IChange_Option_Command
    {
        private readonly string new_Comma_Type;

        /// <summary>
        /// Constructs new command for changing comma type in Options class.
        /// </summary>
        public Change_Comma_Type_Option_Command(string _new_Comma_Type)
        {
            new_Comma_Type = _new_Comma_Type;
        }

        /// <summary>
        /// Change language option in given Options class
        /// </summary>
        public void Change_Option(IOptions_Provider options)
        {
            options.Set_Comma_Type(new_Comma_Type);
        }
    }
}
