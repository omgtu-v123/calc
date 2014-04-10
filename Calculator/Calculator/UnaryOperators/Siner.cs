using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Siner : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}