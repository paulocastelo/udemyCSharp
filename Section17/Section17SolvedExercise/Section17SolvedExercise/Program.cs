using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Section17SolvedExercise.Entities;

namespace Section17SolvedExercise
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter full path file: ");
            //string path = Console.ReadLine();
            string path = @"c:\Projetos\UdemyCSharp\Section17SolvedExercise\in.txt";
            Console.WriteLine(path);
            List<Product> list = new List<Product>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(",");
                        string name = vect[0];
                        double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                        list.Add(new Product(name, price));
                    }
                }
                var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Products average price: " + avg.ToString("F2", CultureInfo.InstalledUICulture));
                Console.WriteLine();

                var r1 =
                    from p in list
                    where p.Price < avg
                    orderby p.Name
                    select p;
                Print("Prices under average test1: ", r1);

                var r2 = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                Print("Prices under average test2: ", r2);
            }
            catch(ArgumentException e)
            {
                throw new ArgumentException("An error has occurred. " + e.Message);
            }
        }
    }
}
