using System;

namespace Calculator.BinaryOperators
{
    class Root : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            return Math.Pow(first, 1 / second).ToString();
        }
    }
}
