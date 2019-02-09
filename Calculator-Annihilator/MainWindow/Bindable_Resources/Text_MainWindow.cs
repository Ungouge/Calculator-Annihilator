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
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }
            //public string  { get; set; }


            protected internal void Set_Texts(MainWindow MainWindow)
            {
                Title = MainWindow.Standard_Messages.Translate("Title");
                Single_Calculations = MainWindow.Standard_Messages.Translate("Single_Calculations");
                Complex_Calculations = MainWindow.Standard_Messages.Translate("Complex_Calculations");
            }
        }
    }
}
