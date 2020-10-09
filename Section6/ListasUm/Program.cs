using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ListasUm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>(); //Apenas instanciou a lista
            List<string> newList = new List<string> { "Koala", "Lion", "Panther" }; //Instanciou e já passou os elementos

            foreach (string item in newList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
