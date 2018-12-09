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
            GUI_Dynamic_Parameters = new MainWindow_Dynamic_Parameters(510, 420);
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            try
            {
                this.DataContext = GUI_Dynamic_Parameters;
                this.Complex_Calculations.IsChecked = true;
                Current_Numeral_System = new Numeral_System(10);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Window_Size_Changed(object sender, SizeChangedEventArgs e)
        {
            //GUI_Dynamic_Parameters.Push_Recalculations();
        }
        public void Window_State_Changed(object sender, EventArgs e)
        {
                GUI_Dynamic_Parameters.Push_Recalculations();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            GUI_Dynamic_Parameters.Push_Recalculations();
        }
    }
}
