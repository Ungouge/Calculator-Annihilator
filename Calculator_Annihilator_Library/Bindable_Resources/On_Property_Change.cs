using System;
using System.ComponentModel;

namespace Calculator_Annihilator_Library
{
    partial class Bindable_Resources : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Handles changed events for property of passed Name
        /// </summary>
        private void On_Property_Change(string Property_Name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property_Name));
        }
    }
}