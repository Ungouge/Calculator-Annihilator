using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Bindable_Resources // General options tab  texts
    {
        public string Language_Name { get; set; }
        public string Font_Size_Type_Name { get; set; }

        private void Set_General_Options_Texts(IStandard_Messages_Translate standard_Messages)
        {
            Language_Name = standard_Messages.Translate("Language");
            Font_Size_Type_Name = standard_Messages.Translate("Font_Size_Type");

            On_Properties_Change(new string[]
            {
                "Language_Name",
                "Font_Size_Type_Name"
            });
        }
    }
}