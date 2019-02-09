using System;
using System.Xml;
using System.Collections.Generic;

namespace Calculator_Annihilator
{
    partial class Standard_Messages
    {
        private void Add_To_Dictionary(XmlNode Node)
        {
            if (Dictionary_With_Placeholders.ContainsKey(Node.Name) == true ||
                Dictionary.ContainsKey(Node.Name) == true)
                return;

            XmlNode Entry = Node.SelectSingleNode(language_Name_Code);

            if (Entry == null)
                return;

            string message = Entry.InnerText;

            XmlNode Placeholders = Node.SelectSingleNode("Placeholders");

            if (Placeholders != null)
            {
                List<string> placeholders_Names_List = new List<string>();

                foreach (XmlNode Placeholder in Placeholders)
                {
                    placeholders_Names_List.Add('[' + Placeholder.InnerText + ']');
                }

                Func<string[], string> func = Create_Function_To_Return_Text(message, placeholders_Names_List);

                Dictionary_With_Placeholders.Add(Node.Name, func);
            }
            else
            {
                Func<string> func = Create_Function_To_Return_Text(message);

                Dictionary.Add(Node.Name, func);
            }
        }

        private static Func<string[], string> Create_Function_To_Return_Text(string message, List<string> placeholders_Names_List)
        {
            return x =>
            {
                string output = message;

                for (int i = 0; i < placeholders_Names_List.Count; i++)
                {
                    message.Replace(placeholders_Names_List[i], x[i]);
                }

                return output;
            };
        }

        private static Func<string> Create_Function_To_Return_Text(string message)
        {
            return () => message;
        }
    }
}
