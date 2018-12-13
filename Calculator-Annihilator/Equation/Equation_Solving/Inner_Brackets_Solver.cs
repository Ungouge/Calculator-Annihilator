using System;
using System.Windows;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		/// <summary>
		/// Solves given bracket and returns solved number as result.
		/// </summary>
		/// <param name="elements">Equation elements sorce list.</param>
		/// <param name="Current_Bracket_Pair">Pairs of brackets that inner equation is to be solved.</param>
		/// <returns></returns>
		private Number Inner_Brackets_Solver(Equation_Elements elements, Bracket_Pair Current_Bracket_Pair)
		{
			foreach (Bracket_Pair Inner_Bracket_pair in Current_Bracket_Pair.Inner_Brackets)
			{
				int Index_Of_Open_Bracket = elements.IndexOf(Inner_Bracket_pair._Open_Bracket);
				int Lenght_Of_Current_Bracket =
					elements.IndexOf(Inner_Bracket_pair._Close_Bracket) - Index_Of_Open_Bracket + 1;

				Number Solved_Inner_Bracket = Inner_Brackets_Solver(
                    new Equation_Elements(elements.GetRange(Index_Of_Open_Bracket + 1, Lenght_Of_Current_Bracket - 2)),
                    Inner_Bracket_pair
                    );

				Exchange_Solved_Range_to_Calculated_Value(
                    elements, Index_Of_Open_Bracket, Lenght_Of_Current_Bracket, Solved_Inner_Bracket);
			}

            Number Result_Of_Current_Bracket;

            try
            {
                Result_Of_Current_Bracket = No_Bracket_Solver(elements);
            }
            catch (EquationIsEmptyException)
            {
                MessageBox.Show($"Something went wrong equation or part of eqaution: {elements.Recreate_Equation()} " +
                    $"had been solved improperly so \"0\" been pushed as result of shown equation.{Environment.NewLine}" +
                    "If there is an error in input eqution correct or try write write equation in other way");
                Result_Of_Current_Bracket = new Number(0);
            }
            catch (EquationNotSolvedProperlyException e)
            {
                MessageBox.Show($"Something went wrong equation or part of eqaution: {elements.Recreate_Equation()} " +
                    $"had been solved as \"{e.Message}\" so \"0\" been pushed as result of shown equation.{Environment.NewLine}" +
                    "If there is an error in input eqution correct or try write write equation in other way");
                Result_Of_Current_Bracket = new Number(0); ;
            }

            return Result_Of_Current_Bracket;
		}
	}
}
