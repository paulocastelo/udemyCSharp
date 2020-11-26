using Section15SolvedExercises.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Section15SolvedExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file full path: ");
            string path = Console.ReadLine();
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(" ");
                        set.Add(new LogRecord(vect[0],DateTime.Parse(vect[1])));
                    }
                }
                Console.WriteLine("Total users: " + set.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
