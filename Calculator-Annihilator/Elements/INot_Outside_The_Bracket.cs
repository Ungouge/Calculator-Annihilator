using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	interface INot_Outside_The_Bracket : INot_Outside_The_Open_Bracket, INot_Outside_The_Close_Bracket
	{
	}
	interface INot_Outside_The_Open_Bracket : IElement
	{
	}
	interface INot_Outside_The_Close_Bracket : IElement
	{
	}
}
