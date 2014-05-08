using System;

namespace Calculator.BinaryOperators
{
    public class Root : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            if (first < 0)
            {
                throw new Exception("Значение под корнем не может быть отрицательным");
            }
            return Math.Pow(first, 1 / second);
        }
    }
}
