using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryAndDiretoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Projetos\myfolder";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string f in folders)
                {
                    Console.WriteLine(f);
                }
                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Console.WriteLine("Creating " + path + @"\newfolder");
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
