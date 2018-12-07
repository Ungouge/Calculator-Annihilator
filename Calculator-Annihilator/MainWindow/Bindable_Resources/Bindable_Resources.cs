using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        private partial class Bindable_Resources
        {
            public Bindable_Resources()
            {

            }

            private int _number_Rows_In_ButtonGrid;

            public int number_Rows_In_ButtonGrid
            {
                get { return _number_Rows_In_ButtonGrid; }
                set { _number_Rows_In_ButtonGrid = 4; }
            }

            private int _number_Columns_In_ButtonGrid;

            public int number_Columns_In_ButtonGrid
            {
                get { return _number_Columns_In_ButtonGrid; }
                set { _number_Columns_In_ButtonGrid = 7; }
            }
        }
    }
}
