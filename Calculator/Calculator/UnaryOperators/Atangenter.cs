using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnaryOperators
{
    public class Atangenter : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            if (argument < -Math.PI/2 || argument > Math.PI/2)
            {
                throw new Exception("Значение арктангенса должно лежать в пределах от -ПИ до ПИ");
            }
            return Math.Atan(argument);
        }
    }
}