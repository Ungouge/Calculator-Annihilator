using System;

namespace Common_Library
{
    interface IStandard_Messages_Translate
    {
        string Translate(string code);

        string Translate(string code, string[] arr);
    }
}
