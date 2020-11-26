using System;
using Section15GetHashCodeAndEquals.Entities;

namespace Section15GetHashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "Alex";
            //string c = "Maria";

            //Console.WriteLine(c.GetHashCode());
            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client() { Name = "Alex", Email = "alex@gmail.com" };
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
