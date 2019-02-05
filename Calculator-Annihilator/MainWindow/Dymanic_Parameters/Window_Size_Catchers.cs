using System;

namespace Calculator_Annihilator
{
    partial class MainWindow
    {
        partial class Dynamic_Parameters
        {
            private double _Window_Height;

            /// <summary>
            /// Gets and sets hight of MainWindow.
            /// </summary>
            public double Window_Height
            {
                get { return _Window_Height; }
                set
                {
                    _Window_Height = value;
                }
            }
            private double _Window_Width;

            /// <summary>
            /// Gets and sets width of MainWindow.
            /// </summary>
            public double Window_Width
            {
                get { return _Window_Width; }
                set
                {
                    _Window_Width = value;
                }
            }
        }

    }
}
