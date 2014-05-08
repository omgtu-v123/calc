using System;

namespace Calculator.BinaryOperators
{
    public class Logarithm : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            if (first == 0 || first == 1)
            {
                throw new Exception("Значение основания логарифма не может быть равно нулю и единице");
            }
            return Math.Log(first, second);
        }
    }
}
