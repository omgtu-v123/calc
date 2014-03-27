using System;
using System.Windows.Forms;

namespace Calculator.BinaryOperators
{
    class Pow : IBinaryOperation
    {
        public string Calculate(double first, double second)
        {
            return Math.Pow(first, second).ToString();
        }
    }
}
