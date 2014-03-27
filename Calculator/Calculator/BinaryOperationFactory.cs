using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.BinaryOperators;

namespace Calculator
{
    public static class BinaryOperationFactory
    {
        public static IBinaryOperation CreateCalculator(string name)
        {
            switch (name)
            {
                case "Additor" : 
                    return new Additor();
                case "Substractor" :
                    return new Substructor();
                case "Multiplicator" :
                    return new Multiplicator();
                case "Divisioner" :
                    return new Divisioner();
                case "Pow":
                    return new Pow();
                case "Root":
                    return new Root();
                case "Logarithm":
                    return new Logarithm();
                case "Radius":
                    return new Radius();
                default: 
                    throw new ArgumentException("Неизвестный тип калькулятора", "name");
            }
        }
    }
}
