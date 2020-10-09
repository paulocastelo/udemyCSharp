using System;
using System.Collections.Generic;
using System.Globalization;

namespace FixacaoListasUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int x = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (int i = 0; i < x; i++)
            {
                int count = i + 1;
                Console.WriteLine("Employee #" + (count) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(name, id, salary));
                Console.WriteLine("");
            }

            bool match = false;
            int limit = 0;

            while (match == false)
            {
                Console.Write("Enter the employee id that will have salary increase: ");
                int searchId = int.Parse(Console.ReadLine());
                Employee empMatches = list.Find(x => x.Id == searchId);
                if (empMatches != null)
                {
                    Console.Write("Enter the percentage of increase: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    empMatches.Increase(percentage);
                    match = true;
                }if (limit == 5)
                {
                    Console.WriteLine("You have reached the maximum number of attempts.");
                    match = true;
                }
                else
                {
                    Console.WriteLine("Id does not exist! Please choose another Id!");
                    limit += 1;
                }
            }

            Console.WriteLine("Updated list:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp);
            }
            
        }
    }
}
