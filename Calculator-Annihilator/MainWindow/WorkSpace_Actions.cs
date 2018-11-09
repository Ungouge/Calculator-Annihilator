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
	public partial class MainWindow
	{
		/// <summary>
		/// Clears current text in workspace and adds given text.
		/// </summary>
		/// <param name="newWorkSpaceText"></param>
		private void Reset_WorkSpace_Text(string newWorkSpaceText)
		{
			WorkSpace.Clear();
			WorkSpace.Text = newWorkSpaceText;

			WorkSpace.CaretIndex = WorkSpace.Text.Length;
			WorkSpace.Focus();
		}

		/// <summary>
		/// Adds to current text in workspace given character in caret position.
		/// </summary>
		private void Insert_To_WorkSpace(char sign)
		{
			int CaretPosition = WorkSpace.CaretIndex;

			if (WorkSpace.SelectionLength == 0)
				WorkSpace.Text = WorkSpace.Text.Insert(CaretPosition++, sign.ToString());
			else
			{
				WorkSpace.Text = WorkSpace.Text.Remove(CaretPosition, WorkSpace.SelectionLength);
				WorkSpace.Text = WorkSpace.Text.Insert(CaretPosition++, sign.ToString());
			}

			WorkSpace.CaretIndex = CaretPosition;
			WorkSpace.Focus();
		}

		/// <summary>
		/// Adds to current text in workspace given string in caret position.
		/// </summary>
		private void Insert_To_WorkSpace(string str)
		{
			int CaretPosition = WorkSpace.CaretIndex;
			WorkSpace.Text = WorkSpace.Text.Insert(CaretPosition, str);
			CaretPosition += str.Length;

			WorkSpace.CaretIndex = CaretPosition;
			WorkSpace.Focus();
		}

		/// <summary>
		/// Removes character preceding caret in workspace.
		/// </summary>
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

		/// <summary>
		/// Clears whole text in workspace.
		/// </summary>
		private void Clear_WorkSpace()
		{
			WorkSpace.Clear();
			WorkSpace.CaretIndex = 0;
			WorkSpace.Focus();
		}
	}
}
