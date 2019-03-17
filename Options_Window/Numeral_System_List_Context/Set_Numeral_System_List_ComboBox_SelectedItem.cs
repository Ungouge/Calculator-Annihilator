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
using System.Windows.Shapes;

namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        private Item_Numeral_System_List_Control Set_Numeral_System_List_ComboBox_SelectedItem(sbyte current_Numeral_System_Code)
        {
            Item_Numeral_System_List_Control List_Control = null;

            try
            {
                List_Control = Find_Numeral_System_Item(current_Numeral_System_Code);
            }
            catch (Exception e )
            {
                List_Control = null;
                MessageBox.Show(e.Message);
            }

            return List_Control;
        }
    }
}

