using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Windows;

namespace Calculator_Annihilator
{
    partial class Standard_Messages
    {
        private void Load_Language(string[] language_Libraries)
        {
            foreach (string direction in language_Libraries)
            {
                Read_Language_Library( direction);
            }
        }

        private void Read_Language_Library(string direction)
        {
            XmlDocument language_Library = new XmlDocument();

            language_Library.Load(direction);

            foreach (XmlNode node in language_Library.DocumentElement)
            {
                Add_To_Dictionary( node);
            }
        }
    }
}

