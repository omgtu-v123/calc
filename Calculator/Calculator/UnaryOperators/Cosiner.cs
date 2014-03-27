using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Cosiner : IUnaryOperation
    {
        public string Calculate(double argument)
        {
            return Math.Cos(argument).ToString();
        }
    }
}
