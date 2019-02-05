using System;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Class for translating string code into text from Language Library files in given language.
    /// </summary>
    internal partial class Standard_Messages
    {
        private Dictionary<string, Func<string[], string>> Dictionary_With_Placeholders;

        private readonly string language_Name_Code;

        /// <summary>
        /// Constructs class Standard Messages loading to dictionary from Language Library files texts 
        /// in given language to translating given string code.
        /// </summary>
        public Standard_Messages(Languages language, string folder_Direction)
        {
            language_Name_Code = Set_Language_Name_Code(language);

            Dictionary_With_Placeholders = new Dictionary<string, Func<string[], string>>();

            string[] language_Libraries = Find_Language_Libraries(folder_Direction);

            Load_Language(language_Libraries);
        }
    }
}
