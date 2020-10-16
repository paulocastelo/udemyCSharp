using System;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.0, 10);

            Console.WriteLine(p);

            p.Nome = "TV 4K";

            Console.WriteLine(p);
        }
    }
}
