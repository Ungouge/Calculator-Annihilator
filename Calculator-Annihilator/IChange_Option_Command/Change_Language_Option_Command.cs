using System;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Changes language in Options class.
    /// </summary>
    internal class Change_Language_Option_Command : IChange_Option_Command
    {
        private readonly Languages Language_To_Change;

        /// <summary>
        /// Constructs new command for changing language in Options class.
        /// </summary>
        internal Change_Language_Option_Command(Languages language_To_Change, bool in_All_Instances)
        {
            Language_To_Change = language_To_Change;
        }

        /// <summary>
        /// Change language option in given Options class
        /// </summary>
        public void Change_Option(Options options)
        {
            options.Set_Language(Language_To_Change);
        }
    }
}
