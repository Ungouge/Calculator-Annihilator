using System;
using Common_Library;

namespace Options_Library
{
    /// <summary>
    /// Changes language in Options class.
    /// </summary>
    public class Add_New_Comma_Type_Option_Command : IChange_Option_Command
    {
        private readonly string[] new_Comma_Types;

        /// <summary>
        /// Constructs new command for adding new comma types in Options class.
        /// </summary>
        public Add_New_Comma_Type_Option_Command(string[] _new_Comma_Types)
        {
            new_Comma_Types = _new_Comma_Types;
        }

        /// <summary>
        /// Change language option in given Options class
        /// </summary>
        public void Change_Option(IOptions_Provider options)
        {
            options.Add_New_Comma_Type(new_Comma_Types);
        }
    }
}