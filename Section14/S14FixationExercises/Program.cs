using S14FixationExercises.Entities;
using S14FixationExercises.Services;
using System;
using System.Globalization;

namespace S14FixationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date(dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter number of installments: ");
                int installments = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Contract contract = new Contract(number, date, totalValue);

                ContractService contractService = new ContractService(new PayPalService());

                contractService.processContract(contract, installments);

                Console.WriteLine("Installments:");
                foreach (Installment installment in contract.Installments)
                {
                    Console.WriteLine(installment);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
