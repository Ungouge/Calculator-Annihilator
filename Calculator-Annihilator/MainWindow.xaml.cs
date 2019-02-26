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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common_Library;
using Windows_Structure;

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow //Initialize Part
    {
        public MainWindow()
        {
            try
            {
                // Preinitialization
                Windows_Manager.Add_MainWindow(this);

                Settings_File_Reader _Settings_File_Reader = new Settings_File_Reader();
                
                GUI_Bindable_Resources = new Bindable_Resources(this);

                Options = _Settings_File_Reader.Options_Generator(this);

                GUI_Bindable_Resources.Intialize_MainWindow_Size();
                
                Back_Parser = new Back_Parser_Fascede(this);

                // Initialization

                InitializeComponent();

                // Postinitialization

                this.DataContext = GUI_Bindable_Resources;

                ComplexCalculations.DataContext = GUI_Bindable_Resources;
                Calculator_Buttons_Panel_Setter();


                if (Options.Calculation_Method == Calculation_Method.Single)
                    this.SingleCalculations.IsChecked = true;
                else // calculation_Method == Calculation_Method.Complex
                    this.ComplexCalculations.IsChecked = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
