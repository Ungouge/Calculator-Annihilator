using System;
using Common_Library;

namespace Options_Window_Library
{
    /// <summary>
    /// Instantiates Comma_Type_List_Content objects.
    /// </summary>
    internal partial class Commas_Type_Item_Factory
    {
        private Bindable_Resources Bindable_Resources;

        private IStandard_Messages_Translate Standard_Messages;

        internal Commas_Type_Item_Factory(Bindable_Resources _Bindable_Resources, IStandard_Messages_Translate _Standard_Messages)
        {
            Bindable_Resources = _Bindable_Resources;

            Standard_Messages = _Standard_Messages;
        }
    }
}
