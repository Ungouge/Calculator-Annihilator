using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Bindable_Resources
        {
            public string Title {get; set;}
            public string Single_Calculations { get; set; }
            public string Complex_Calculations { get; set; }
            public string File { get; set; }
            public string View { get; set; }
            public string Edit { get; set; }
            public string Help { get; set; }
            public string New_Window { get; set; }
            public string Options { get; set; }
            public string Close_Window { get; set; }
            public string Standard { get; set; }
            public string Scientific { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }


            protected internal void Set_Texts(MainWindow MainWindow)
            {
                // \Calculator_Annihilator.xml
                Title                = MainWindow.Standard_Messages.Translate("Title");
                Single_Calculations  = MainWindow.Standard_Messages.Translate("Single_Calculations");
                Complex_Calculations = MainWindow.Standard_Messages.Translate("Complex_Calculations");

                // \Main_Menu.xml
                File         = MainWindow.Standard_Messages.Translate("File");
                View         = MainWindow.Standard_Messages.Translate("View");
                Edit         = MainWindow.Standard_Messages.Translate("Edit");
                Help         = MainWindow.Standard_Messages.Translate("Help");
                New_Window   = MainWindow.Standard_Messages.Translate("New_Window");
                Options      = MainWindow.Standard_Messages.Translate("Options");
                Close_Window = MainWindow.Standard_Messages.Translate("Close_Window");
                Standard     = MainWindow.Standard_Messages.Translate("Standard");
                Scientific   = MainWindow.Standard_Messages.Translate("Scientific");
            }
        }
    }
}
