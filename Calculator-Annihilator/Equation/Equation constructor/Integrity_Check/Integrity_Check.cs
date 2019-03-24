using System;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		/// <summary>
		/// Checks and corrects mistakes in equation.
		/// </summary>
		/// <exception cref="EquationIsEmptyException">
		/// The exception that is thrown when equation class has empty list of elements,
		/// because given text is empty or correction of incorrectly written equation text left no elements in the equation.
		/// </exception>
		private void Integrity_Check()
		{
			Elements_Enumerator Equation_Rator = new Elements_Enumerator(Element_Colection);

			Check_Integrity_Of_Equation_Begining(Equation_Rator);

			if (Equation_Rator.MoveNext() == false)
			{
				IElement Even_Preious_Element = null;

				do
				{
					Check_Integrity_Of_Current_Element(Equation_Rator, Even_Preious_Element);

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

		/// <summary>
		/// Removes wrong elements at the begining of the equation and returns number of removed elements.
		/// </summary>
		/// <param name="Equation_Rator"></param>
		/// <exception cref="EquationIsEmptyException">
		private int Check_Integrity_Of_Equation_Begining(Elements_Enumerator Equation_Rator)
		{
			int removed_Elements = 0;
			if (Equation_Rator.MoveNext() == true)
				throw new EquationIsEmptyException();

			// If equation begings by operand[s] - removes it[them]
			while (Equation_Rator.Current_Element is INot_At_the_Begining)
			{
				if (Element_Colection.RemoveAt(Equation_Rator.Current_Index) == false)
					throw new EquationIsEmptyException();
				removed_Elements++;
			}
			return removed_Elements;
		}
	}
}
