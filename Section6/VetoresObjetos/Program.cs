using System;
using System.Globalization;

namespace VetoresObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of items: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Insert name for item [" + i + "]: ");
                string name = Console.ReadLine();
                Console.Write("Insert price for item [" + i + "]: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            Console.WriteLine("List of inserted items: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i].Name + ", " + vect[i].Price);
            }

            double sum = 0.0;

            for (int i =0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE: " + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
