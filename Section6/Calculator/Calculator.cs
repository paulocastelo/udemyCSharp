using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorParams
{
    class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int Sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Sum += numbers[i];
            }

            return Sum;
        }
    }
}
