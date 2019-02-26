using System;

namespace Calculator_Annihilator
{
	partial class Equation
	{
		/// <summary>
		/// Solves whole equation and gives result to Solved_Value.
		/// </summary>
		private void Solve()
        {
            if (is_Solved == false)
            {
                Number Result_Number = Inner_Brackets_Solver(Element_Colection, Bracket_Map_Root);

                Bracket_Map_Root = null;

                is_Solved = true;

                _Solved_Value = Result_Number;
            }
        }
    }
}

