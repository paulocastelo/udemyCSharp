using Inheritance.Entities;
using System;
using System.Globalization;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert data of account:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, balance);

            Console.WriteLine("Insert data of account:");
            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            holder = Console.ReadLine();
            Console.Write("Balance: ");
            balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Loan: ");
            double loan = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            BusinessAccount bacc = new BusinessAccount(number, holder, balance, loan);

            Console.WriteLine("Upcasting:");
            Console.WriteLine("Account acc1 = bacc;");
            Account acc1 = bacc;

            Console.WriteLine("Account acc2 = new BusinessAccount(1001, Maria, 1500.00, 0.1);");
            Account acc2 = new BusinessAccount(1001, "Maria", 1500.00, 200.0);
            Console.WriteLine("Account acc3 = new SavingsAccount(1003, Joana, 2500.00, 0.01);");
            Account acc3 = new SavingsAccount(1003, "Joana", 2500.00, 0.01);
            Console.WriteLine();
            
            Console.WriteLine("Downcasting:");
            Console.WriteLine("This operation is not secure!");
            Console.WriteLine("BusinessAccount acc4 = (BusinessAccount)acc2;");
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(200.00);
            Console.WriteLine("BusinessAccount acc5 = (BusinessAccount)acc3; --> ERROR");
            Console.WriteLine();

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("acc5.Loan(200.0); --> Ok!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("acc5.UpdateBalance(); --> Ok!");
            }

        }
    }
}
