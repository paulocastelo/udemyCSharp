using FixationExercise.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FixationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootFolderPath = @"C:\Projetos\Files";
            string sourceFileCsv = rootFolderPath + @"\input\source.csv";
            string sourceFolderPath = Path.GetDirectoryName(sourceFileCsv);
            string targetFolderPath = rootFolderPath + @"\output";
            string targetFileCSV = targetFolderPath + @"\target.csv";

            if (!Directory.Exists(rootFolderPath))
            {
                Directory.CreateDirectory(rootFolderPath);
                Directory.CreateDirectory(sourceFolderPath);
                Directory.CreateDirectory(targetFolderPath);
            }

            List<Product> list = new List<Product>();

            try
            {
                if (!File.Exists(sourceFileCsv))
                {
                    Console.WriteLine("Creating source file. . .");
                    string[] text ={ "TV LED, 1290.99, 1"
                    ,"Video Game Chair, 350.50, 3"
                    ,"Iphone X, 900.00, 2"
                    ,"Samsung Galaxy 9, 850.00, 2" };

                    FileInfo newFile = new FileInfo(sourceFileCsv);
                    using (StreamWriter outputSourceFile = new StreamWriter(Path.Combine(sourceFileCsv)))
                    {
                        foreach (string line in text)
                        {
                            outputSourceFile.WriteLine(line);
                        }
                    }
                    Console.WriteLine("Source file created!");
                }

                if (File.Exists(targetFileCSV))
                {
                    File.Delete(targetFileCSV);
                }

                string[] item = File.ReadAllLines(sourceFileCsv);
                Console.WriteLine("Source File:");
                foreach (string s in item)
                {
                    Console.WriteLine(s);
                    string[] addItem = s.Split(", ");
                    string name = addItem[0];
                    double price = double.Parse(addItem[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(addItem[2]);
                    list.Add(new Product(name, price, quantity));
                }
                Console.WriteLine();

                Console.WriteLine("Creating targetFile. . .");
                Console.WriteLine("Target file:");
                using (StreamWriter outputDestinyCSV = new StreamWriter(Path.Combine(targetFileCSV)))
                {
                    foreach (Product product in list)
                    {
                        Console.WriteLine(product);
                        outputDestinyCSV.WriteLine(product);
                    }
                }
                Console.WriteLine("Target file created!");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
