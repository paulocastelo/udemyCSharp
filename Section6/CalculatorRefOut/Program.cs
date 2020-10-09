using System;

namespace CalculatorRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int triple;
            Calculator.Triple2(a, out triple);
            Console.WriteLine(triple);
        }


    }
}
