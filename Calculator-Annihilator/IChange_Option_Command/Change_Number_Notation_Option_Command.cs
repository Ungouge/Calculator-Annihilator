using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    class Change_Number_Notation_Option_Command : IChange_Option_Command
    {
        private readonly Number_Notation Number_Notation_To_Change;

        /// <summary>
        /// Constructs new command for changing language in Options class.
        /// </summary>
        internal Change_Number_Notation_Option_Command(Number_Notation number_Notation_To_Change)
        {
            Number_Notation_To_Change = number_Notation_To_Change;
        }

        /// <summary>
        /// Change font size type option in given Options class
        /// </summary>
        public void Change_Option(Options options)
        {
            options.Set_Number_Notation(Number_Notation_To_Change);
        }
    }
}
