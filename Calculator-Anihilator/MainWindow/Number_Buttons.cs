using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator_Anihilator
{
	public partial class MainWindow //Number buttons sack
	{
		private void Button_0_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('0');
		}

		private void Button_1_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('1');
		}

		private void Button_2_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('2');
		}

		private void Button_3_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('3');
		}

		private void Button_4_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('4');
		}

		private void Button_5_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('5');
		}

		private void Button_6_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('6');
		}

		private void Button_7_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('7');
		}

		private void Button_8_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('8');
		}

		private void Button_9_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace('9');
		}

		private void Button_Comma_Click(object sender, RoutedEventArgs e)
		{
			Insert_To_WorkSpace(',');
		}
	}
}
