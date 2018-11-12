using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private void Integrity_Check() 
		{
			IElement Even_Preious_Element = null;

			Elements_Enumerator Equation_Rator = new Elements_Enumerator(Element_Colection);

			if (Equation_Rator.MoveNext() == true)
				throw new EquationIsEmptyException("1");

			// If equation begings by operand[s] - removes it[them]
			while (Equation_Rator.Current_Element is INot_At_the_Begining)
				if (Element_Colection.RemoveAt(Equation_Rator.Current_Index) == false)
					throw new EquationIsEmptyException("2");

			if (Equation_Rator.MoveNext() == false)
			{
				do
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
							Integrity_Check();
							break;
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

					Even_Preious_Element = Equation_Rator.Previous_Element;

				} while (Equation_Rator.MoveNext() == false);
			}

			if (Element_Colection.Count < 1)
				throw new EquationIsEmptyException();

			while (Element_Colection[Element_Colection.Count - 1] is INot_At_The_End)
			{
				Element_Colection.RemoveAt(Element_Colection.Count - 1);
				if (Element_Colection.Count < 1)
					throw new EquationIsEmptyException();
			}
		}
	}
}
