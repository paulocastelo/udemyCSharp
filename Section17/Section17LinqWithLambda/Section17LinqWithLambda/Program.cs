using System;
using System.Linq;
using System.Collections.Generic;
using Section17LinqWithLambda.Entities;

namespace Section17LinqWithLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>
            {
                new Product() { Id = 1 , Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() { Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() { Id = 7, Name = "Camera", Price = 700.0 , Category = c3},
                new Product() { Id = 8, Name = "Printer", Price = 350.0 , Category = c3},
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0 , Category = c2},
                new Product() { Id = 10, Name = "Sound bar", Price = 700.0 , Category = c3},
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1}
            };
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

            //With no using Auxiliar Function
            //Console.WriteLine("TIER 1 and Price < 900:");
            //foreach (Product p in r1)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine();

            //With Auxiliar Function
            Print("TIER 1 and Price < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name + ", " + p.Price);
            Print("Only tools:", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => p.Name + ", " + p.Category.Name + ", " + p.Price);
            Print("Only product started with C:", r3);

            var r4 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, CategoryName = p.Category.Name, p.Price });
            Print("Only product started with C and ANONYMOUS:", r4);

            var r5 = products.Where(p => p.Category.Tier == 1).OrderByDescending(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price and product name:", r5);

            var r6 = r5.Skip(2).Take(4);
            Print("Tier 1 order by price and product name skip 2 take 4:", r6);

            var r7 = products.FirstOrDefault();
            Console.WriteLine("First record or default: " + r7);
            Console.WriteLine();

            var r8 = products.FirstOrDefault(p => p.Price > 3000.0);
            Console.WriteLine("First record or default: " + r8);
            Console.WriteLine();

            var r9 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r9);

            var r10 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r10);

            var r11 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r11);

            var r12 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r13);

            var r14 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 average prices: " + r14);

            var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 average prices: " + r15);

            var r16 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (X, y) => X + y); //Zero if return is empty.
            Console.WriteLine("Category 1 aggregate prices: " + r16); Console.WriteLine();

            var r17 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category,Product> group in r17)
            {
                Console.WriteLine("Category: " + group.Key.Name);
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
