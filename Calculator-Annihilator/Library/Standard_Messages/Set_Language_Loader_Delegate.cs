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
                case Languages.Polish:
                    return "Polski";
                case Languages.German:
                    return "Deutsch";
                case Languages.Latin:
                    return "Latina";
                case Languages.Chinese:
                    return "Zhongguo";
                default:
                    return "No_Language";
            }
        }
    
    }
}