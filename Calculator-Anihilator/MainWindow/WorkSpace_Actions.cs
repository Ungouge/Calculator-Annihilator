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

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		private void Insert_To_WorkSpace(char sign)
		{
			int CaretPosition = WorkSpace.CaretIndex;
			WorkSpace.Text = WorkSpace.Text.Insert(CaretPosition++, sign.ToString());
			WorkSpace.CaretIndex = CaretPosition;
			WorkSpace.Focus();
		}

		private void Insert_To_WorkSpace(string signs)
		{
			int CaretPosition = WorkSpace.CaretIndex;
			WorkSpace.Text = WorkSpace.Text.Insert(CaretPosition, signs);
			CaretPosition += signs.Length;
			WorkSpace.CaretIndex = CaretPosition;
			WorkSpace.Focus();
		}

		private void BackSpace_WorkSpace()
		{
			int CaretPosition = WorkSpace.CaretIndex;
			if (CaretPosition > 0)
			{
				CaretPosition--;
				WorkSpace.Text = WorkSpace.Text.Remove(CaretPosition, 1);
				WorkSpace.CaretIndex = CaretPosition;
			}
			WorkSpace.Focus();
		}

		private void Clear_WorkSpace()
		{
			WorkSpace.Text = "";
			WorkSpace.CaretIndex = 0;
			WorkSpace.Focus();
		}

		private void WorkSpace_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			;
		}
	}
}
