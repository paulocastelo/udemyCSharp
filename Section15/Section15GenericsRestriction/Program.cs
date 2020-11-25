using Section15GenericsRestriction.Entities;
using Section15GenericsRestriction.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Section15GenericsRestriction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(',');
                string name = values[0];
                double price = double.Parse(values[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));

            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);
            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}
