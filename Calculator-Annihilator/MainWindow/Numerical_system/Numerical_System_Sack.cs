using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	public partial class MainWindow
	{
		public void Set_Current_Numerical_System(sbyte ns)
		{
			Current_Numerical_System = new Numerical_System(ns);
		}
	}
}
