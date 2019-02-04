using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    internal partial class Standard_Messages
    {
        private Dictionary<string, Func<string>> dictionary;

        string[] language_Libraries = new string[]
        {
            @"C:\Users\Kamil\Desktop\C#\GUI\Calculator-Annihilator\Calculator-Annihilator\Library\Language_Library\Language_Library.xml"
        };

        public Standard_Messages(Language language, string folder_Direction)
        {
            Load_Language(language, folder_Direction);
        }
    }
}
