using FixationExercise.Entities;
using FixationExercise.Entities.Exceptions;
using System;
using System.Globalization;

namespace FixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char repeat = 'Y';
                while (repeat == 'Y')
                {
                    Console.WriteLine("Enter account data");
                    Console.Write("Number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    string holder = Console.ReadLine();
                    Console.Write("Initial balance: ");
                    double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Withdraw limit: ");
                    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Account account = new Account(number, holder, balance, withdrawLimit);
                    Console.WriteLine();
                    Console.Write("Enter amount for withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.Withdraw(withdraw);


                    Console.WriteLine();
                    Console.WriteLine("Do you wish another operation? (Y/N)");
                    repeat = char.Parse(Console.ReadLine().ToUpper());
                }
            }
            catch (FormatException f)
            {
                Console.WriteLine("Error on inserted datas! " + f.Message);
            }
            catch (DomainException d)
            {
                Console.WriteLine("Error on Business Rules! " + d.Message);
            }
        }
    }
}
