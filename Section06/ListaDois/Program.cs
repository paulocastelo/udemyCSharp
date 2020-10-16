using System;
using System.Collections.Generic;

namespace ListaDois
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("White Tiger");
            list.Add("Lion");
            list.Add("Lynx");
            list.Insert(3, "Onca");
            list.Insert(0, "Cat");

            Console.WriteLine("List count: " + list.Count + " items.");
            Console.Write("How much items you want to insert? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("Insert item's name: ");
                list.Add(Console.ReadLine());
            }

            foreach (string felino in list)
            {
                Console.WriteLine(felino);
            }

            string s1 = list.Find(Test);//CALLING FUNCTION

            string s2 = list.Find(x => x[0] == 'O');//LAMBDA EXPRESSION
            Console.WriteLine("--------------------------------");
            int pos1 = list.FindIndex(x => x[0] == 'C');
            Console.WriteLine("First position 'O': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'C');
            Console.WriteLine("First position 'O': " + pos2);
            Console.WriteLine("--------------------------------");
            List<string> filteredList = list.FindAll(x => x.Length ==5);

            foreach (string feline in filteredList)
            {
                Console.WriteLine("Feline with lenght name equals 5: "+ feline);
            }
        }

        static bool Test(string s) //FUNCTION
        {
            return s[0] == 'L'; //The character L must be on the position 0
        }
    }
}
