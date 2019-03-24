using System;
using Common_Library;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class for parsing text to number or digits in current numeral system
    /// </summary>
    partial class Parser
    {
        Numeral_System Numeral_System;

        internal Parser(Numeral_System numeral_System)
        {
            Numeral_System = numeral_System;
        }
    }
}