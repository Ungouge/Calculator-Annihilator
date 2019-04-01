using System;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		/// <summary>
		/// Clears current text in workspace and adds given text.
		/// </summary>
		/// <param name="newWorkSpaceText"></param>
		public void Reset_WorkSpace_Text(string newWorkSpaceText)
        {
            WorkSpace.Clear();
            WorkSpace.Text = newWorkSpaceText;

            Move_WorkSpace_Carret_To_End();
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
		public void Insert_To_WorkSpace(string str)
		{
			int CaretPosition = WorkSpace.CaretIndex;
			WorkSpace.Text = WorkSpace.Text.Insert(CaretPosition, str);
			CaretPosition += str.Length;

			WorkSpace.CaretIndex = CaretPosition;
			WorkSpace.Focus();
        }

        /// <summary>
        /// Adds to current text in workspace given string in passed position.
        /// </summary>
        public void Insert_To_WorkSpace(int start_Index, string str)
        {
            int CaretPosition = WorkSpace.CaretIndex;

            WorkSpace.Text = WorkSpace.Text.Insert(start_Index, str);

            CaretPosition += str.Length;
            WorkSpace.CaretIndex = CaretPosition;

            WorkSpace.Focus();
        }

        /// <summary>
        /// Adds to current text in workspace given character in passed position.
        /// </summary>
        public void Insert_To_WorkSpace(int start_Index, char sign)
        {
            int CaretPosition = WorkSpace.CaretIndex;

            WorkSpace.Text = WorkSpace.Text.Insert(start_Index, sign.ToString());

            WorkSpace.CaretIndex = ++CaretPosition;

            WorkSpace.Focus();
        }

        /// <summary>
        /// Adds to current text in workspace given string in passed position.
        /// Removes a specified number of characters in the work space at a specified position.
        /// </summar
        public void Remove_From_WorkSpace(int start_Index, int count)
        {
            int CaretPosition = WorkSpace.CaretIndex;

            try
            {
                WorkSpace.Text = WorkSpace.Text.Remove(start_Index, count);

                CaretPosition -= count; 

                WorkSpace.CaretIndex = CaretPosition;
            }
            catch (ArgumentOutOfRangeException)
            {
                WorkSpace.Text = WorkSpace.Text.Substring(start_Index);

                WorkSpace.CaretIndex = WorkSpace.Text.Length;
            }

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

        private void Move_WorkSpace_Carret_To_End()
        {
            WorkSpace.CaretIndex = WorkSpace.Text.Length;
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
