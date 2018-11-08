using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private bool Check_Integrity_Of_Current_Element(Equation_Elements _Equation_Elements, Elements_Enumerator Equation_Rator, IElement Previous_Element)
		{
			IElement Current_Element = Equation_Rator.Current_Element;

			if (Current_Element is Open_Bracket && Previous_Element is INot_Outside_The_Open_Bracket)
			{
				Previous_Element = Insert_Missing_Multiplication_InFront_Of_Bracket(_Equation_Elements, Equation_Rator);
				return false;
			}

			if (Previous_Element is Operand && Current_Element is Operand)
			{
				if (_Equation_Elements.Remove(Current_Element))
					return true;
				else
					return false;
			}

			if (Previous_Element is Open_Bracket && Current_Element is Close_Bracket)
			{
				_Equation_Elements.Remove(Previous_Element);
				Equation_Rator.Reset();   // for now is ok - thing about something better
				Equation_Rator.MoveNext();
				if (_Equation_Elements.Remove(Current_Element))
					return true;
				else
					return false;
			}

			if (Previous_Element is Close_Bracket && Current_Element is INot_Outside_The_Close_Bracket)
			{
				_Equation_Elements.Insert(Equation_Rator.Current_Index, new Multiplication());
				return false;
			}

			return true;
		}

		private static IElement Insert_Missing_Multiplication_InFront_Of_Bracket(Equation_Elements _Equation_Elements, Elements_Enumerator Equation_Rator)
		{
			IElement New_Element = new Multiplication();

			_Equation_Elements.Insert(Equation_Rator.Current_Index, New_Element);

			return New_Element;
		}
	}
}
