using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução com núméricos:");
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a -= 3;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 4;
            Console.WriteLine(a);
            a %= 2;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a--;
            a--;
            Console.WriteLine(a);
            int b = a++;
            Console.WriteLine("O valor de B é:" + b);
            int c = ++a;
            Console.WriteLine("O valor de C é:" + c);

            Console.WriteLine("--------");
            Console.WriteLine("Execução com String:");
            string s = "ABCDEF";
            Console.WriteLine(s);
            s += "GHIJKL";
            Console.WriteLine(s);
        }
    }
}
