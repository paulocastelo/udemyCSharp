using System;
using System.IO;
using System.Collections.Generic;
using Section14IComparable.Entities;

namespace Section14IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSTR = @"C:\Projetos\UdemyCSharp\Section14\Section14IComparable\lista.txt";
            string pathCSV= @"C:\Projetos\UdemyCSharp\Section14\Section14IComparable\lista.csv";
            try
            {
                Console.WriteLine();
                Console.WriteLine("Processing TXT");
                using (StreamReader sr = File.OpenText(pathSTR))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Processing CSV:");
                using (StreamReader sr = File.OpenText(pathCSV))
                {
                    List<Employee> listEmployee = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        listEmployee.Add(new Employee (sr.ReadLine()));
                    }
                    listEmployee.Sort();
                    foreach (Employee emp in listEmployee)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
