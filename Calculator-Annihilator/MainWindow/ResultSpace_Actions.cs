using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		/// <summary>
		/// Clears current text in result space and adds given text.
		/// </summary>
		/// <param name="new_ResultSpace_Text"></param>
		private void Reset_ResultSpace_Text(string new_ResultSpace_Text)
		{
			ResultSpace.Clear();
			ResultSpace.Text = new_ResultSpace_Text;
		}

		/// <summary>
		/// Adds to current text in result space given character.
		/// </summary>
		private void Insert_To_ResultSpace(char _char) // xyz: so far not used - remove if not needed
		{
			Insert_To_ResultSpace(_char.ToString());
		}

		/// <summary>
		/// Adds to current text in result space given string.
		/// </summary>
		private void Insert_To_ResultSpace(string _string)
		{
			ResultSpace.Text = ResultSpace.Text.Insert(ResultSpace.Text.Length, _string);
		}

		/// <summary>
		/// Clears whole text from result space.
		/// </summary>
		private void Clear_ResultSpace()
		{
			ResultSpace.Clear();
		}
	}
}
