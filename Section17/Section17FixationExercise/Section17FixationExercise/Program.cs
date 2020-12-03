using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Section17FixationExercise.Entities;


namespace Section17FixationExercise
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = @"C:\Projetos\UdemyCSharp\Section17FixationExercise\Section17FixationExercise\in.txt";
            Console.WriteLine(path);
            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!(sr.EndOfStream))
                    {
                        string[] vect = sr.ReadLine().Split(",");
                        string name = vect[0];
                        string email = vect[1];
                        double salary = double.Parse(vect[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.Write("Enter salary: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var emailMoreThan = from employee in list
                                    where employee.Salary < value
                                    orderby employee.Name
                                    select employee.Email;
                Print("Email of people whose salary is more than " + value + ":", emailMoreThan);

                var peoplesWithM = from employee in list
                                where employee.Name[0] == 'M'
                                select employee.Salary;
                Print("People whose name starts with 'M': ",peoplesWithM);

                var sumSalary2 = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                //var sumSalary2 = list.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();
                Console.Write("Sum of salary of people whose name starts with 'M': " + sumSalary2);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("An error has occurred! " + e.Message);
            }
        }
    }
}
