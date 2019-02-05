using System;
using System.IO;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Standard_Messages
    {
        public string[] Find_Language_Libraries(string folder_Direction)
        {
            return Directory.GetDirectories(folder_Direction, "*.xml", SearchOption.AllDirectories);
        }
    }
}
