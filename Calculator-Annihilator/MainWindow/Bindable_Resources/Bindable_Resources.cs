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

            private int _Number_Rows_In_ButtonGrid;

            public int Number_Rows_In_ButtonGrid
            {
                get { return _Number_Rows_In_ButtonGrid; }
                set { _Number_Rows_In_ButtonGrid = 4; }
            }

            private int _Number_Columns_In_ButtonGrid;

            public int Number_Columns_In_ButtonGrid
            {
                get { return _Number_Columns_In_ButtonGrid; }
                set { _Number_Columns_In_ButtonGrid = 7; }
            }
        }
    }
}
