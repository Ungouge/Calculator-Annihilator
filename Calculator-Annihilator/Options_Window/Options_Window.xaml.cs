﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for Options_Window.xaml
    /// </summary>
    public partial class Options_Window : Window
    {
        public Bindable_Resources _Bindable_Resources;

        Standard_Messages Standard_Messages;

        internal Options_Window(Standard_Messages _Standard_Messages)
        {
            Standard_Messages = _Standard_Messages;
            _Bindable_Resources = new Bindable_Resources(this);
            InitializeComponent();
            this.DataContext = _Bindable_Resources;
            Language_List_ComboBox.DataContext = _Bindable_Resources;
        }
    }
}
