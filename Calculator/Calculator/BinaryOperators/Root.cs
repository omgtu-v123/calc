using System;

namespace Calculator.BinaryOperators
{
    public class Root : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1 / second);
        }
    }
}
