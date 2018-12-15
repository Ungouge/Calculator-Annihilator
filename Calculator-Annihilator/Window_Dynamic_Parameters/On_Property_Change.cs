using System;
using System.ComponentModel;

namespace Calculator_Annihilator
{
    partial class Window_Dynamic_Parameters : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Handles changed events for property of passed Name
        /// </summary>
        protected internal void On_Property_Change(string Property_Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Property_Name));
            }
        }
    }
}