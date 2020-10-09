using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            Console.WriteLine(genero);
            char caractere = '\u0041';
            sbyte x = 100;
            Console.WriteLine(x);


            string nome = "Maria";
            Console.WriteLine(nome);

            object obj1 = "Mr. John";
            Console.WriteLine(obj1);

            byte n1 = 126;
            Console.WriteLine(n1);
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483647L;
            float n5 = 4.5f;
            double n6 = 4.5;
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            int n7 = int.MaxValue;
            Console.WriteLine(n7);
            int n8 = int.MinValue;
            Console.WriteLine(n8);
            int n9 = n7 - n8;
            Console.WriteLine(n9);
        }
    }
}
