using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Cotangenter : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            return (1/Math.Tan(argument));
        }
    }
}
