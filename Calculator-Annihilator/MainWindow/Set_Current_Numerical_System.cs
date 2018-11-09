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
		/// 
		/// </summary>
		/// <param name="ns">Base of new numeral system or encoded number for exotic numeral system(check Numerical_System description).</param>
		public void Set_Current_Numerical_System(sbyte new_Numeral_System_Base)
		{
			Current_Numerical_System = new Numerical_System(new_Numeral_System_Base);
		}
	}
}
