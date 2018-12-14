using System;
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

namespace Calculator_Annihilator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window //Initialize Part
    {
        public MainWindow()
        {
            // Preinitialization
            try
            { 
            Settings_File_Reader _Settings_File_Reader = new Settings_File_Reader();
            _Static_Resources = new Static_Resources(_Settings_File_Reader);
            GUI_Dynamic_Parameters = new Dynamic_Parameters(_Settings_File_Reader);

            // Initialization
            
                InitializeComponent();

            // Postinitialization
            
                this.DataContext = GUI_Dynamic_Parameters;

                if (_Settings_File_Reader.calculation_Method == Calculation_Method.Single)
                    this.SingleCalculations.IsChecked = true;
                else // calculation_Method == Calculation_Method.Complex
                    this.ComplexCalculations.IsChecked = true;

                Current_Numeral_System = new Numeral_System(_Settings_File_Reader.initial_Numeral_System);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
