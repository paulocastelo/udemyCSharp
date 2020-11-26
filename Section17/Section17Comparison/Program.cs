using System;
using System.Collections.Generic;
using Section17Comparison.Entities;

namespace Section17Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tabled", 450.00));

            Comparison<Product> compName = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //LAMBDA EXPRESSION

            Console.WriteLine("Ordering by name:");
            list.Sort(compName);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine("Ordering by price:");
            Comparison<Product> compPrice = (p1, p2) => p1.Price.CompareTo(p2.Price);
            list.Sort(compPrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
