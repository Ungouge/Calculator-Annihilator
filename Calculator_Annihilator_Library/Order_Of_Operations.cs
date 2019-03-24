using System;

namespace Calculator_Annihilator_Library
{
    /// <summary>
    /// Static libraries of components for calculation.
    /// </summary>
    static partial class Order_Of_Operations
    {
        /// <summary>
        /// Jagged array of operand classes on order of operatin.
        /// </summary>
        internal static readonly IOperand[][] Operands = new IOperand[][]
        {
            new IOperand [] { new Expontent() },
            new IOperand [] { new Division(), new Multiplication() },
            new IOperand [] { new Subtraction(), new Addition() }
        };

        //Be aware to mach both arrays!!!!!

        /// <summary>
        /// Jagged array of operand characters on order of operatin.
        /// </summary>
        internal static readonly char[][] operand_Sings = new char[][]
        {
            new char [] { '^' },
            new char [] { '/', '*' },
            new char [] { '-', '+' }
        };
    }
}
