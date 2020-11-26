using System;
using System.Collections.Generic;

namespace Section15HashsetSortedset
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("PC");
            set.Add("Car");
            set.Add("House");
            set.Add("iPhone");
            set.Add("Gym");
            set.Add("Notebook");
            Console.WriteLine("Is there a Notebook in the set? " + set.Contains("Notebook"));

            Console.WriteLine("Printing all elements in the set.");
            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            PrintCollection(a);
            PrintCollection(b);

            Console.WriteLine();
            Console.WriteLine("Union");
            //SortedSet<int> c = new SortedSet<int>();
            //foreach (int x in a)
            //{
            //    c.Add(x);
            //}
            //foreach (int y in b)
            //{
            //    c.Add(y);
            //}
            //Direct mode
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            Console.WriteLine();
            Console.WriteLine("Intersection");
            SortedSet<int> d =  new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            Console.WriteLine();
            Console.WriteLine("Difference");
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}