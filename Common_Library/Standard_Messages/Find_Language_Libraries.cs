using System;
using System.IO;
using System.Collections.Generic;

namespace Common_Library
{
    partial class Standard_Messages
    {
        public string[] Find_Language_Libraries(string folder_Direction)
        {
            return Directory.GetFiles(folder_Direction, "*", SearchOption.AllDirectories);
        }
    }
}
