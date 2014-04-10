using System;
using System.Windows.Forms;

namespace Calculator.BinaryOperators
{
    public class Pow : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
