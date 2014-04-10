using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Exp : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
