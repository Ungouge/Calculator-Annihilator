﻿using System;
using Common_Library;

namespace Calculator_Annihilator_Library
{
    /// <summary>
    /// Class for parsing text to number or digits in current numeral system
    /// </summary>
    public partial class Parser
    {
        Numeral_System Numeral_System;

        public Parser(Numeral_System numeral_System)
        {
            Numeral_System = numeral_System;
        }
    }
}