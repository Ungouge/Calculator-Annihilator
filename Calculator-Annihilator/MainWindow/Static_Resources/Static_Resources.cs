namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Class containing getters and setters for static resourcess of MainWindow.
        /// </summary>
        internal partial class Static_Resources
        {
            private Settings_File_Reader _Settings_File_Reader;

            /// <summary>
            /// Constructs new Static_Resources class reading and setting resorcess for MainWindow .
            /// </summary>
            internal Static_Resources(MainWindow _MainWindow, Settings_File_Reader __Settings_File_Reader)
            {
                _Settings_File_Reader = __Settings_File_Reader;
                _Settings_File_Reader.Push_Static_Settings(_MainWindow, this);
            }

            private int _Number_Rows_In_ButtonGrid;

            protected internal int Number_Rows_In_ButtonGrid // not binded jet
            {
                get { return _Number_Rows_In_ButtonGrid; }
                set { _Number_Rows_In_ButtonGrid = value; }
            }

            private int _Number_Columns_In_ButtonGrid;

            protected internal int Number_Columns_In_ButtonGrid // not binded jet
            {
                get { return _Number_Columns_In_ButtonGrid; }
                set { _Number_Columns_In_ButtonGrid = value; }
            }
        }
    }
}
