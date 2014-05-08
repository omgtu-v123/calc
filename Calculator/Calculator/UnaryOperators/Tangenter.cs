using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Tangenter : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            if (Math.Abs(argument - Math.PI / 2) < 0.0001)
            {
                throw new Exception("Значение аргумента тангенса не может быть ПИ");
            }
            return Math.Tan(argument);
        }
    }
}
