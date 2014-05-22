using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.UnaryOperators
{
    public class Asiner : IUnaryOperation
    {
        public double Calculate(double argument)
        {
            if (argument < -Math.PI/2 || argument > Math.PI/2)
            {
                throw new Exception("Значение арксинуса должно лежать в пределах от -ПИ/2 до ПИ/2");
            }
            return Math.Asin(argument);
        }
    }
}
