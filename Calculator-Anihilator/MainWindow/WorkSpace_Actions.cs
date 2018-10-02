using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Anihilator
{
	public partial class MainWindow
	{
		private void Insert_To_WorkSpace(string sign)
		{
			int CaretPosition = WorkSpace.CaretIndex;
			WorkSpace.Text = WorkSpace.Text.Insert(CaretPosition++, sign);
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

		private void WorkSpace_PreviewKeyDown(object sender, KeyEventArgs e) // To elaborate
		{
			e.Handled = !Is_Key_Allowed(e.Key);
		}

		private bool Is_Key_Allowed(Key key)  // To elaborate like about
		{
			return !numerical_System_Signs.Equals(key);
		}
	}
}
