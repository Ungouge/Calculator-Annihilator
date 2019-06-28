using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    /// <summary>
    /// Class for parsing text to number or digits in current numeral system
    /// </summary>
    public partial class Parser
    {
        private Numeral_System Numeral_System;

        private string[] Commas_Type;

        public Parser(Numeral_System numeral_System, string[] _Commas_Type)
        {
            Numeral_System = numeral_System;

            Commas_Type = _Commas_Type;
        }
    }
}