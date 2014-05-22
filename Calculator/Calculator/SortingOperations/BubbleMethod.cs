using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SortingOperations
{
    public class BubbleMethod : ISortingOperation 
    {
        public int[] SortingCalculate(int[] argument)
        {
            int temp;

            for (int i = 0; i < argument.Length - 1; i++)
            {
                for (int j = 0; j < argument.Length - i - 1; j++)
                {
                    if (argument[j] > argument[j + 1])
                    {
                        temp = argument[j];
                        argument[j] = argument[j + 1];
                        argument[j + 1] = temp;
                    }
                }
            }
            return argument;
        }
    }
}
