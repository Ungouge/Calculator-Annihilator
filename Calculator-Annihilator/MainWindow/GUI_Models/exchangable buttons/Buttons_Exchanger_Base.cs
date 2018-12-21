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
    class Buttons_Exchanger_Base
    {
        protected Button Button;

        protected Calculation_Method Calculation_Method;

        protected IButton_Changer Buttons_Controller;

        public Buttons_Exchanger_Base(Button _Button, Calculation_Method _Calculation_Method, IButton_Changer _Buttons_Controller)
        {
            Button = _Button;

            Calculation_Method = _Calculation_Method;

            Buttons_Controller = _Buttons_Controller;
        }
    }
}
