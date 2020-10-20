using ProposedExercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProposedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List <Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (Y/N)? ");
                char t = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double additionalCharge = 0;
                if (t == 'Y')
                {
                    Console.Write("Additional Charge: ");
                    additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                if (t == 'N')
                {
                    Employee e = new Employee(name, hours, valuePerHour);
                    employees.Add(e);
                }
                else
                {
                    OutsourcedEmployee o = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(o);
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
