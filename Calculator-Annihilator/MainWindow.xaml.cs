﻿using System;
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
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Numeral_System = 10;
			Current_Numerical_System = new Numerical_System_Signs(Numeral_System);
			Numerical_System_Signs = Current_Numerical_System.System_Digits;
			//WorkSpace.Text = "(58, 53 + 57) - 54, 2 * 25";

		}

		private void Reset_WorkSpace_Text(string newWorkSpaceText)
		{
			Clear_WorkSpace();

			Insert_To_WorkSpace(newWorkSpaceText);
		}
	}
}
