using System;
using Section16ExtensionMethods.Extensions;

namespace Section16ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 01, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            string s1 = "Good morning dear students";
            Console.WriteLine(s1.Cut(15));
        }
    }
}
