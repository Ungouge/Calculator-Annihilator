using System;
using System.Xml;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Standard_Messages
    {
        /// <summary>
        /// Returns string code of given language enumerator.
        /// </summary>
        private string Set_Language_Name_Code(Languages language)
        {
            switch (language)
            {
                case Languages.English:
                    return "English";
                case Languages.Polski:
                    return "Polski";
                case Languages.Deutsch:
                    return "Deutsch";
                case Languages.Latin:
                    return "Latina";
                case Languages.Zhongguo:
                    return "Zhongguo";
                default:
                    return "No_Language";
            }
        }
    
    }
}