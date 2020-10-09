using System;

namespace CalculatorParams
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Estrutura sem params
            int s1 = Calculator.Sum(new int[] { 2, 5, 10 });
            int s2 = Calculator.Sum(new int[] { 10, 15, 20 });

            
            */
            int s1 = Calculator.Sum(2, 5, 10 );
            int s2 = Calculator.Sum(10, 15, 20);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
