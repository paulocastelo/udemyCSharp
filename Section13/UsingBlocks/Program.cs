using System;
using System.IO;

namespace UsingBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Projetos\file1.txt";
            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                //}
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
