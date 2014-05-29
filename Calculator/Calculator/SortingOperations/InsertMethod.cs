using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SortingOperations
{
    public class InsertMethod : ISortingOperation
    {
        public int[] SortingCalculate(int[] argument)
        {
            int tmp;
            for (int i = 1, j; i < argument.Length; ++i)
            {
                tmp = argument[i];
                for (j = i - 1; j >= 0 && argument[j] > tmp; --j)
                    argument[j + 1] = argument[j];
                argument[j + 1] = tmp;
            }
            return argument;
        }
    }
}
