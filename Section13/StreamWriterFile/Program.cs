using System;
using System.Globalization;
using System.IO;

namespace StreamWriterFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Projetos\file1.txt";
            string targetPath = @"C:\Projetos\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string s in lines)
                    {
                        sw.WriteLine(s.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
