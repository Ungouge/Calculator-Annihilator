﻿using System;
using Common_Library;

namespace Common_Library
{
    partial class Numeral_System
    {
        public static string Numeral_System_Dictionary_Name(sbyte numeral_System_Code, IStandard_Messages_Translate standard_Messages)
        {
            if (numeral_System_Code > 0 && numeral_System_Code < 65)
            {
                return standard_Messages.Translate("N-Base_Numeral_System",
                    new string[] { numeral_System_Code.ToString() });
            }

            switch (numeral_System_Code)
            {
                case -2:
                    return standard_Messages.Translate("Negabinary_Numeral_System");
                case -3:
                    return standard_Messages.Translate("Balanced_Ternary_Numeral_System");
            }

            return standard_Messages.Translate("Unknown_Numeral_System");
        }
    }
}