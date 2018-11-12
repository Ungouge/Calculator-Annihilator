using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private bool Check_Integrity_Of_Current_Element(Elements_Enumerator Equation_Rator)
		{
			IElement Current_Element = Equation_Rator.Current_Element;
			IElement Previous_Element = Equation_Rator.Previous_Element;

			if (Current_Element is Open_Bracket && Previous_Element is INot_Outside_The_Open_Bracket)
			{
				Element_Colection.Insert(Equation_Rator.Current_Index, new Multiplication());
				return true;
			}

			if (Previous_Element is Operand && Current_Element is Operand)
			{
				if (Element_Colection.RemoveAt(Equation_Rator.Current_Index) == true)
					return true;
				else
				{
					Equation_Rator--;
					return false;
				}
			}

			if (Previous_Element is Open_Bracket && Current_Element is Close_Bracket)
			{
				bool is_Last = Element_Colection.RemoveAt(Equation_Rator.Current_Index);

				Equation_Rator--;

				Element_Colection.RemoveAt(Equation_Rator.Current_Index);

				Equation_Rator--;

				return is_Last;
			}

			if (Previous_Element is Close_Bracket && Current_Element is INot_Outside_The_Close_Bracket)
			{
				Element_Colection.Insert(Equation_Rator.Current_Index, new Multiplication());
				return true;
			}

			if (Previous_Element is Open_Bracket && Current_Element is INot_Intside_Bracket )
			{
				if (Element_Colection.RemoveAt(Equation_Rator.Current_Index) == true)
				{
					Equation_Rator--;
					return true;
				}
				else
				{
					Equation_Rator--;
					return false;
				}
			}

			if (Current_Element is Close_Bracket && Previous_Element is INot_Intside_Bracket)
			{
				if (Element_Colection.RemoveAt(Equation_Rator.Current_Index - 1) == true)
				{
					Equation_Rator--;
					return true;
				}
				else
				{
					Equation_Rator--;
					return false;
				}
			}

			return false;
		}
	}
}
