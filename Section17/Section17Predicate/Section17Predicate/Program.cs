using Section17Predicate.Entities;
using System;
using System.Collections.Generic;

namespace Section17Predicate
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

            list.RemoveAll(ProductTest);
            list.RemoveAll(p => p.Price >= 100);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}
