using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class CubeSqrt : IUnaryOperation
    {
        public string Calculate(double argument)
        {
            return Math.Pow(argument,1.0/3).ToString();
        }
    }
}