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
        partial class Bindable_Resources : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChange(string PropertName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(PropertName));
                }
            }
        }
    }
}
