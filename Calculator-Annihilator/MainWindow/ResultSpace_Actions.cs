using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		private void Reset_ResultSpace_Text(string new_ResultSpace_Text)
		{
			ResultSpace.Clear();
			ResultSpace.Text = new_ResultSpace_Text;
		}

		private void Insert_To_ResultSpace(char _char)
		{
			Insert_To_ResultSpace(_char.ToString());
		}

		private void Insert_To_ResultSpace(string _string)
		{
			ResultSpace.Text = ResultSpace.Text.Insert(ResultSpace.Text.Length, _string);
		}

		private void Clear_ResultSpace()
		{
			ResultSpace.Clear();
		}
	}
}
