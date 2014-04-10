using System;

namespace Calculator.BinaryOperators
{
    public class Radius : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return (Math.Pow((Math.Pow(first,2) + Math.Pow(second,2)), 0.5));
        }
    }
}
