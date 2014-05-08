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
            if (argument < 0 || argument > Math.PI)
            {
                throw new Exception("Значение арктангенса должно лежать в пределах от 0 до ПИ");
            }
            return (1/Math.Tan(argument));
        }
    }
}
