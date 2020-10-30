using System;
using System.IO;

namespace FIlesSection
{
    class Program
    {
        static void Main(string[] args)
        {
            string createPath = @"C:\Projetos\file1.txt";
            string sourcePath = @"C:\Projetos\file1.txt"; // @ IS TO NON REPEAT "\" CHARACTER
            string targePath = @"C:\Projetos\file2.txt"; // @ IS TO NON REPEAT "\" CHARACTER
            try
            {
                if (!File.Exists(createPath))
                {
                    string[] text = { "Good morning!", "Good afternoon!", "Good night!" };
                    FileInfo newFile = new FileInfo(createPath);
                    using (StreamWriter outPutNewFile = new StreamWriter(Path.Combine(createPath)))
                    {
                        foreach(string line in text)
                        {
                            outPutNewFile.WriteLine(line);
                        }
                    }
                }
                else
                {
                    if (File.Exists(createPath))
                    {
                        File.Delete(createPath);
                    }
                    string[] text = { "Good morning!", "Good afternoon!", "Good night!" };
                    FileInfo newFile = new FileInfo(createPath);
                    using (StreamWriter outPutNewFile = new StreamWriter(Path.Combine(createPath)))
                    {
                        foreach (string line in text)
                        {
                            outPutNewFile.WriteLine(line);
                        }
                    }
                }
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targePath, true);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e);
            }
        }
    }
}
