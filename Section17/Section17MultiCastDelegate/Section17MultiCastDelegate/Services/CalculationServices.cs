using System;
using System.Collections.Generic;
using System.Text;

namespace Section17MultiCastDelegate.Services
{
    class CalculationServices
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine("Max: " + max);
        }
        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum: " + sum);
        }
    }
}
