using System;
using System.Xml;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Standard_Messages
    {
        public string Translate(string code)
        {
            return Translate(code, new string[] { });
        }

        public string Translate(string code, string[] arr)
        {
            if (Dictionary_With_Placeholders.ContainsKey(code) == false)
                return code;

            return Dictionary_With_Placeholders[code]( arr);
        }
    }
}