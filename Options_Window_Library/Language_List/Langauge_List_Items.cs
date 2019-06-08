using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Item with resources for Language_List_ComboBox.
    /// </summary>
    public class Langauge_List_Items
    {
        public string Language_Name { get; private set; }

        public string Language_Flag_Uri { get; private set; }

        internal Languages Language;

        /// <summary>
        /// Constructs item for given Language.
        /// </summary>
        internal Langauge_List_Items(IStandard_Messages_Translate Standard_Messages, Languages _Language)
        {
            Language = _Language;

            Language_Name = Standard_Messages.Translate(Language.ToString() + "_Native");

            Language_Flag_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Language_Flags\" + Language.ToString() + "_Flag.png";
        }
    }
}