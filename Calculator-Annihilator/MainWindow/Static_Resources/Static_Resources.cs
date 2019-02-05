namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        /// <summary>
        /// Class containing getters and setters for static resourcess of MainWindow.
        /// </summary>
        public partial class Static_Resources
        {
            private Settings_File_Reader Settings_File_Reader;

            //private MainWindow MainWindow; //can be deleted if Set text no longer needs this

            /// <summary>
            /// Constructs new Static_Resources class reading and setting resorcess for MainWindow .
            /// </summary>
            internal Static_Resources(MainWindow _MainWindow, Settings_File_Reader __Settings_File_Reader)
            {
                //MainWindow = _MainWindow;
                Settings_File_Reader = __Settings_File_Reader;
                Settings_File_Reader.Push_Static_Settings(_MainWindow, this);
            }
        }
    }
}
