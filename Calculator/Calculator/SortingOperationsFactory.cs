using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.SortingOperations;


namespace Calculator
{
    public static class SortingOperationsFactory
    {
        public static ISortingOperation CreateCalculator(string name)
        {
            switch (name)
            {
                case "Bubble": 
                    return new BubbleMethod();
                case "Chose":
                    return new ChoseMethod();
                default:
                    throw new ArgumentException("Неизвестный тип сортировки", "name");
            }
        }
    }
}
