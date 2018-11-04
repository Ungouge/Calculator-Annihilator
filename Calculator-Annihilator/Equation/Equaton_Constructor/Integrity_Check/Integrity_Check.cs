using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		private void Integrity_Check(Equation_Elements _Equation_Elements) 
		// xyz: If there would be no need for additional checks during run of the solver remove passing te _Eqation_Elements
		{
			Elements_Enumerator Equation_Rator = new Elements_Enumerator(_Equation_Elements);;

			Equation_Rator.MoveNext();

			IElement Previous_Element = Equation_Rator.Current_Element;

			// If equation begings by operand[s] - removes it[them]
			while (Previous_Element is INot_At_the_Begining)
			{
				_Equation_Elements.Remove(Previous_Element);

				Previous_Element = Equation_Rator.Current_Element;
			}

			while (Equation_Rator.MoveNext() == false)
			{
				bool do_MoveNext;

				do
				{
					do_MoveNext = Check_Integrity_Of_Current_Element(_Equation_Elements, Equation_Rator, Previous_Element);
				} while (do_MoveNext == false);

				Previous_Element = Equation_Rator.Current_Element;
			}

			while( _Equation_Elements[_Equation_Elements.Count - 1] is INot_At_The_End Last_Element)
			{
				_Equation_Elements.Remove(Last_Element);
			}
		}
	}
}
