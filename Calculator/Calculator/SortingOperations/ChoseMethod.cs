using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SortingOperations
{
    public class ChoseMethod : ISortingOperation
    {
        public int[] SortingCalculate(int[] argument)
        {
            int tmp;
            for (int i = 0; i < argument.Length; ++i)
            {
                int pos = i;
                tmp = argument[i];
                for (int j = i + 1; j < argument.Length; ++j)
                {
                    if (argument[j] < tmp)
                    {
                        pos = j;
                        tmp = argument[j];
                    }
                }
                argument[pos] = argument[i];
                argument[i] = tmp;
            }
            return argument;
        }
    }
}
