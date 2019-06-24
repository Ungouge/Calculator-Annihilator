using System;
using Common_Library;

namespace Options_Window_Library
{
    partial class Numeral_System_List_Context
    {
        /// <summary>
        /// Abstract factory for constructing item for Numeral_System_List_ComcoBox.
        /// </summary>
        internal partial class Numeral_System_List_Content_Factory
        {
            private IStandard_Messages_Translate Standard_Messages;

            private Numeral_System_List_Context Numeral_System_List_Context;

            /// <summary>
            /// Construct Numeral_System_List_Content_Factory for given resources.
            /// </summary>
            internal Numeral_System_List_Content_Factory(Numeral_System_List_Context _Numeral_System_List_Context, IStandard_Messages_Translate _Standard_Messages)
            {
                Standard_Messages = _Standard_Messages;

                Numeral_System_List_Context = _Numeral_System_List_Context;
            }
        }
    }
}