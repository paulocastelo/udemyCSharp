using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };


            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("----------------------------------------------");
            foreach(string obj in vect) // O nome pode ser OBJ ou qualquer letra/palavra
            {
                Console.WriteLine(obj);
            }
        }
    }
}
