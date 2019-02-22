using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    class Change_Numeral_System_Option_Command : IChange_Option_Command
    {
        private readonly sbyte numeral_System_To_Change;

        /// <summary>
        /// Constructs new command for changing language in Options class.
        /// </summary>
        internal Change_Numeral_System_Option_Command(sbyte _numeral_System_To_Change)
        {
            numeral_System_To_Change = _numeral_System_To_Change;
        }

        /// <summary>
        /// Change font size type option in given Options class
        /// </summary>
        public void Change_Option(Options options)
        {
            options.Set_Numeral_System(numeral_System_To_Change);
        }
    }
}
