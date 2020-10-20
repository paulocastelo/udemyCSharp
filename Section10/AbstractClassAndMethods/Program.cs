using AbstractClassAndMethods.Entities;
using AbstractClassAndMethods.Entities.Enums;
using AbstractClassAndMethods.Entities.Shapes;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert data of account:");
            //Console.Write("Number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Holder: ");
            //string holder = Console.ReadLine();
            //Console.Write("Balance: ");
            //double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //SavingsAccount acc = new SavingsAccount(number, holder, balance, interestRate);

            //Console.WriteLine("Insert data of account:");
            //Console.Write("Number: ");
            //number = int.Parse(Console.ReadLine());
            //Console.Write("Holder: ");
            //holder = Console.ReadLine();
            //Console.Write("Balance: ");
            //balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Loan: ");
            //double loan = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //BusinessAccount bacc = new BusinessAccount(number, holder, balance, loan);

            //Console.WriteLine("Upcasting:");
            //Console.WriteLine("Account acc1 = bacc;");
            //SavingsAccount acc1 = bacc;

            //Console.WriteLine("Account acc2 = new BusinessAccount(1001, Maria, 1500.00, 0.1);");
            //SavingsAccount acc2 = new BusinessAccount(1001, "Maria", 1500.00, 200.0);
            //Console.WriteLine("Account acc3 = new SavingsAccount(1003, Joana, 2500.00, 0.01);");
            //SavingsAccount acc3 = new SavingsAccount(1003, "Joana", 2500.00, 0.01);
            //Console.WriteLine();

            //Console.WriteLine("Downcasting:");
            //Console.WriteLine("This operation is not secure!");
            //Console.WriteLine("BusinessAccount acc4 = (BusinessAccount)acc2;");
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(200.00);
            //Console.WriteLine("BusinessAccount acc5 = (BusinessAccount)acc3; --> ERROR");
            //Console.WriteLine();

            //if (acc3 is BusinessAccount)
            //{
            //    BusinessAccount acc5 = (BusinessAccount)acc3;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("acc5.Loan(200.0); --> Ok!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = (SavingsAccount)acc3;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("acc5.UpdateBalance(); --> Ok!");
            //}

            Console.Write("Enter the number of shapes:");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine().ToUpper());

                double width, height, radius = 0.0;

                Console.Write("Color: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (type == 'R')
                {
                    Console.Write("Width: ");
                    width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }
                else if (type == 'C')
                {
                    Console.Write("Radius: ");
                    radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));
                }
                else
                {
                    Console.Write("Invalid option!");
                }
            }
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
