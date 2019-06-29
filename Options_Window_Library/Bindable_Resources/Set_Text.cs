using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Bindable_Resources
    {
        /// <summary>
        /// Sets bindable texts according to currently setted language.
        /// </summary>
        public void Set_Text(IStandard_Messages_Translate standard_Messages)
        {
            Set_Tab_Item_Texts(standard_Messages);

            Set_General_Options_Texts(standard_Messages);

            Set_Buttons_Texts(standard_Messages);

            Set_Calculator_Options_Text(standard_Messages);

            _Comma_Type_List_Context.Set_Item_Text(standard_Messages);

            _Number_Notation_List_Context.Set_Item_Text(standard_Messages);

            _Langauge_List_Context.Set_Item_Text(standard_Messages);

            _Font_Size_List_Context.Set_Item_Text(standard_Messages);

            _Numeral_System_List_Context.Set_Item_Text(standard_Messages);
        }
    }
}