using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Static_Resources
        {
            // Do still need this.
            private object _NumberKeys_Panel_DataContext;

            public object NumberKeys_Panel_DataContext
            {
                get { return _NumberKeys_Panel_DataContext; }
                set {
                    
                    _NumberKeys_Panel_DataContext = value; }
            }
            
            private object _BasicOperations_Panel_DataContext;

            public object BasicOperations_Panel_DataContext
            {
                get { return _BasicOperations_Panel_DataContext; }
                set { _BasicOperations_Panel_DataContext = value; }
            }

        }
    }
}