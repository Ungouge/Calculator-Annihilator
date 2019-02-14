using System;
using System.IO;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Standard_Messages
    {
        public string[] Find_Language_Libraries(string folder_Direction)
        {
            return Directory.GetFiles(folder_Direction, "*", SearchOption.AllDirectories);
        }
    }
}
