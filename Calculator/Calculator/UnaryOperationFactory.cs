using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.UnaryOperators;

namespace Calculator
{
    public static class UnaryOperationFactory
    {
        public static IUnaryOperation CreateCalculator(string name)
        {
            switch (name)
            {
                case "siner":
                    return new Siner();
                case "cosiner":
                    return new Cosiner();
                case "tangenter": 
                    return new Tangenter();
                case "cotangenter": 
                    return new Cotangenter();
                case "Asiner":
                    return new Asiner();
                case "Acosiner":
                    return new Acosiner();
                case "Atangenter":
                    return new Atangenter();
                case "Acotangenter":
                    return new Acotangenter();
                case "Sqrt":
                    return new Sqrt();
                case "CubeSqrt":
                    return new CubeSqrt();
                case "NatLog":
                    return new NatLoger();
                case "Exp":
                    return new Exp();
                default:
                    throw new ArgumentException("Неизвестный тип калькулятора", "name");
            }
        }
    }
}
