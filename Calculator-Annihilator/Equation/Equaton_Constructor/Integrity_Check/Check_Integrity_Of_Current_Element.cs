using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{

		private void Check_Integrity_Of_Current_Element(Elements_Enumerator Equation_Rator, IElement Even_Preious_Element)
		{
			IElement Current_Element = Equation_Rator.Current_Element;
			IElement Previous_Element = Equation_Rator.Previous_Element;

			if (Even_Preious_Element is Bracket && Equation_Rator.Previous_Element is IOperand && Equation_Rator.Current_Element is Bracket)
			{
				if (Even_Preious_Element is Open_Bracket || Equation_Rator.Current_Element is Close_Bracket)
				{
					Element_Colection.RemoveAt(Equation_Rator.Current_Index);
					Equation_Rator--;
					Element_Colection.RemoveAt(Equation_Rator.Current_Index);

					int removed_Element = Check_Integrity_Of_Equation_Begining(new Elements_Enumerator(Element_Colection));
					for (int i = 0; i <= removed_Element; i++)
					{
						Equation_Rator--;
					}
				}
			}
			else if (Current_Element is Open_Bracket && Previous_Element is INot_Outside_The_Open_Bracket)
			{
				Element_Colection.Insert(Equation_Rator.Current_Index, new Multiplication());
				Equation_Rator--;
			}
			else if (Previous_Element is Operand && Current_Element is Operand)
			{
				Element_Colection.RemoveAt(Equation_Rator.Current_Index);
				Equation_Rator--;
			}
			else if (Previous_Element is Open_Bracket && Current_Element is Close_Bracket)
			{
				Element_Colection.RemoveAt(Equation_Rator.Current_Index);

				Equation_Rator--;

				Element_Colection.RemoveAt(Equation_Rator.Current_Index);

				Equation_Rator--;
			}
			else if (Previous_Element is Close_Bracket && Current_Element is INot_Outside_The_Close_Bracket)
			{
				Element_Colection.Insert(Equation_Rator.Current_Index, new Multiplication());
				Equation_Rator--;
			}
			else if (Previous_Element is Open_Bracket && Current_Element is INot_Intside_Bracket)
			{
				Element_Colection.RemoveAt(Equation_Rator.Current_Index);

				Equation_Rator--;
			}
			else if (Current_Element is Close_Bracket && Previous_Element is INot_Intside_Bracket)
			{
				Element_Colection.RemoveAt(Equation_Rator.Current_Index - 1);

				Equation_Rator--;
			}
		}
	}
}
