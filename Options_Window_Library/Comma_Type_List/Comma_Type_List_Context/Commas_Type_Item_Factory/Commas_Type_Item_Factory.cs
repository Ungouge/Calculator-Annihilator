using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Factory for Comma_Type_List_Content objects.
    /// </summary>
    internal partial class Commas_Type_Item_Factory
    {
        private Comma_Type_List_Context Comma_Type_List_Context;

        private IStandard_Messages_Translate Standard_Messages;

        internal Commas_Type_Item_Factory(Comma_Type_List_Context _Comma_Type_List_Context, IStandard_Messages_Translate _Standard_Messages)
        {
            Comma_Type_List_Context = _Comma_Type_List_Context;

            Standard_Messages = _Standard_Messages;
        }
    }
}
