using ProposedExercises2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProposedExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (type == 'C')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            double totalTaxes = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                totalTaxes += taxPayer.Tax();
                Console.WriteLine(taxPayer);
            }
            Console.WriteLine();
            Console.WriteLine("Total taxes: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
