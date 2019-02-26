using System;
using Common_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        partial class Langauge_List_Context
        {
            public class Langauge_List_Items
            {
                public string Language_Name { get; set; }

                public string Language_Flag_Uri { get; set; }

                internal Languages Language;

                internal Langauge_List_Items(OWXYZ _OptionsWindow, Languages _Language)
                {
                    Language = _Language;

                    Language_Name = _OptionsWindow.Options.Standard_Messages.Translate( Language.ToString() + "_Native" );

                    Language_Flag_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Language_Flags\" + Language.ToString() + "_Flag.png";
                }
            }
        }
    }
}
