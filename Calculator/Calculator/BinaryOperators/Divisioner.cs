using System;
namespace Calculator.BinaryOperators
{
    public class Divisioner : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Значение второго аргумента не может быть равно нулю");
            }
            return (first / second);
        }
    }
}
