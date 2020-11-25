using System;

namespace Section15Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();
            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.first());

            PrintService<int> printService2 = new PrintService<int>();
            Console.Write("How many values: ");
            string s = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService2.AddValue(x);
            }

            printService2.Print();
            Console.WriteLine("First: " + printService2.first());
        }
    }
}
