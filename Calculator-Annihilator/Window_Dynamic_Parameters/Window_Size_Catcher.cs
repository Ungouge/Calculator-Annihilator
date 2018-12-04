using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
    partial class Window_Dynamic_Parameters
    {
        private double _Window_Height;

        public double Window_Height
        {
            get { return _Window_Height; }
            set
            {
                _Window_Height = value;

                foreach (string Property_Name in Names_Of_properties_To_Handle)
                {
                    OnPropertyChange(Property_Name);
                }
            }
        }
        private double _Window_Width;

        public double Window_Width
        {
            get { return _Window_Width; }
            set
            {
                _Window_Width = value;

                foreach (string Property_Name in Names_Of_properties_To_Handle)
                {
                    OnPropertyChange(Property_Name);
                }
            }
        }

    }
}
