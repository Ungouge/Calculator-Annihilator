using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        partial class Numeral_System_Items_List
        {
            /// <summary>
            /// Abstract factory for constructing item for Numeral_System_List_ComcoBox.
            /// </summary>
            internal partial class Numeral_System_List_Content_Factory
            {
                private Bindable_Resources Bindable_Resources;

                private IStandard_Messages_Translate Standard_Messages;

                /// <summary>
                /// Construct Numeral_System_List_Content_Factory for given resources.
                /// </summary>
                /// <param name="_Bindable_Resources"></param>
                /// <param name="_Standard_Messages"></param>
                internal Numeral_System_List_Content_Factory(Bindable_Resources _Bindable_Resources, IStandard_Messages_Translate _Standard_Messages)
                {
                    Bindable_Resources = _Bindable_Resources;

                    Standard_Messages = _Standard_Messages;
                }
            }
        }
    }
}