using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    partial class Window_Dynamic_Parameters
    {
        /// <summary>
        /// Pushes properties setted to be recalculated on call.
        /// </summary>
        internal void Push_Recalculations()
        {
            foreach (string Property_Name in Names_Of_properties_To_Handle)
            {
                On_Property_Change(Property_Name);
            }
        }
    }
}
