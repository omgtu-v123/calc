using System;

namespace Calculator.BinaryOperators
{
    public class Logarithm : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            return Math.Log(first, second).ToString();
        }
    }
}
