using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		interface INot_Outside_Of_Equation : INot_At_the_Begining, INot_At_The_End
		{
		}
		interface INot_At_the_Begining : IElement
		{
		}
		interface INot_At_The_End : IElement
		{
		}
	}
}
