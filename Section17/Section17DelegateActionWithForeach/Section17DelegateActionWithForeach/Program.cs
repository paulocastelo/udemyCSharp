using System;
using System.Collections.Generic;
using Section17DelegateActionWithForeach.Entities;


namespace Section17DelegateActionWithForeach
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

            list.ForEach(UpdatePrice);
            list.Sort();

            Action<Product> act = PrintProduct;
            list.ForEach(act);

        }
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        static void PrintProduct(Product p)
        {
            Console.WriteLine(p);
        }
    }
}
