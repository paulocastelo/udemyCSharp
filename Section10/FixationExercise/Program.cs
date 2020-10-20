using FixationExercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace FixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, Used or Imported (C / U / I)? ");
                char type = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                double customFee = 0.0;
                DateTime manufactureDate = DateTime.Now;

                if (type == 'I')
                {
                    Console.Write("Customs fee: ");
                    customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                }
                
                if (type == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufactureDate = DateTime.Parse(Console.ReadLine());
                }

                Product product;

                if (type == 'C')
                {
                    product = new Product(name, price);
                    list.Add(product);
                }
                else if (type == 'U')
                {
                    product = new UsedProduct(name, price, manufactureDate);
                    list.Add(product);
                }
                else if (type == 'I')
                {
                    product = new ImportedProduct(name, price, customFee);
                    list.Add(product);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
