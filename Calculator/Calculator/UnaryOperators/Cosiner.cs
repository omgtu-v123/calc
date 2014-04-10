using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Cosiner : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
