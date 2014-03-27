using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Acosiner : IUnaryOperation
    {
        public string Calculate(double argument)
        {
            return Math.Acos(argument).ToString();
        }
    }
}