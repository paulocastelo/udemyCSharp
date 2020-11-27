using System;
using System.Linq;
using System.Collections.Generic;
using Section17DelegateFuncWithSelect.Entities;

namespace Section17DelegateFuncWithSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD case", 80.90));

            list.ForEach(PrintProduct);

            Func<Product, string> func = NameUpper;
            List<string> result = list.Select(func).ToList();
            
            Console.WriteLine("\nUsing Lambda in line: ");
            result.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("\nUsing Action:");
            Action<string> act = PrintString;
            result.ForEach(act);
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        static void PrintString(string p)
        {
            Console.WriteLine(p);
        }
        static void PrintProduct(Product p)
        {
            Console.WriteLine(p);
        }
    }
}
