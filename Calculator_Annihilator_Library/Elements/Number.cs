using System;

namespace Calculator_Annihilator_Library
{
    /// <summary>
    /// Contains given value as double type.
    /// </summary>
    public class Number : IElement_ToString, INumber, INot_Outside_The_Bracket
    {
        public double Value { get; private set; }

        public Number(double v)
        {
            Value = v;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
    
    //xyz add Null number to logic

    /// <summary>
    /// Contains given value as double type.
    /// </summary>
    public class Number_Null : IElement_ToString, INumber, INot_Outside_The_Bracket
    {
        public double Value { get; private set; }

        public Number_Null()
        {
            Value = 0;
        }

        public override string ToString()
        {
            return "0";
        }
    }
}
