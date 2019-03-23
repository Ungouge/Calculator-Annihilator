using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Options_Window_Library
{
    partial class Add_New_Comma_Type_Control
    {
        private void Add_New_Comma_Click(object sender, RoutedEventArgs e)
        {
            Comma_Type_List_Context.Add_New_Comma_Type(Add_New_Comma_TextBox.Text);

            Add_New_Comma_TextBox.Text = default(string);

            Add_New_Comma.Focus();
        }
    }
}
