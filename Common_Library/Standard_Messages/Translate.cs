using System;
using System.Xml;
using System.Collections.Generic;

namespace Common_Library
{
    partial class Standard_Messages
    {
        public string Translate(string code)
        {
            if (Dictionary.ContainsKey(code) == false)
                return code;

            return Dictionary[code]();
        }

        public string Translate(string code, string[] arr)
        {
            if (Dictionary_With_Placeholders.ContainsKey(code) == false)
                return code;

            return Dictionary_With_Placeholders[code](arr);
        }
    }
}