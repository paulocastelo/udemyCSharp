using System;
using System.Collections.Generic;
using System.IO;

namespace Section15DictionaryProposedExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string test = Console.ReadLine();
            string path = @"C:\Projetos\UdemyCSharp\Section15DictionaryProposedExercise\Section15DictionaryProposedExercise\in.txt";
            Dictionary<string, int> votingRecord = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(",");
                        string name = vect[0];
                        int vote = int.Parse(vect[1]);
                        if (votingRecord.ContainsKey(name))
                        {
                            votingRecord[name] += vote;
                        }
                        else
                        {
                            votingRecord.Add(name, vote);
                        }
                    }
                }
                foreach (var candidate in votingRecord)
                {
                    Console.WriteLine(candidate.Key + ", " + candidate.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
