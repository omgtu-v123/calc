using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Acotangenter : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            if (argument < 0 || argument > Math.PI)
            {
                throw new Exception("Значение арккотангенса должно лежать в пределах от 0 до ПИ");
            }
            return (Math.PI/2 - Math.Atan(argument));
        }
    }
}