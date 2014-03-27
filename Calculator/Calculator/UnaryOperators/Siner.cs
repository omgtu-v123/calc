using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Siner : IUnaryOperation
    {
        public string Calculate(double argument)
        {
            return Math.Sin(argument).ToString();
        }
    }
}