using System;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		/// <summary>
		/// Exchange single operation to solve result.
		/// </summary>
		/// <param name="elements">Equation elements sorce list.</param>
		/// <param name="operand_index">Index of operator to exchange.</param>
		/// <param name="Result_Number">Result to insert.</param>
		private void Exchange_Solved_to_Simple_Calculated_Value (
            Equation_Elements elements, int operand_index, Number Result_Number)
		{
			elements.ReplaceRange(operand_index - 1, 3, Result_Number);
		}
		/// <summary>
		/// Exchange given range of equation elements to single number.
		/// </summary>
		/// <param name="elements">Equation elements sorce list.</param>
		/// <param name="operand_index">The zero-based index at which item should be inserted.</param>
		/// <param name="count">The number of elements to remove.</param>
		/// <param name="Result_Number">Result to insert.</param>
		private void Exchange_Solved_Range_to_Calculated_Value (
            Equation_Elements elements, int operand_index, int count, Number Result_Number)
		{
			elements.ReplaceRange(operand_index, count, Result_Number);
		}
	}
}
