using System;
using System.Globalization;

namespace DateTimeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = new DateTime(2020, 10, 10);
            DateTime d4 = new DateTime(2020, 10, 10, 21, 54, 22);
            DateTime d5 = new DateTime(2020, 10, 10, 21, 54, 22, 500);
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.Parse("2020-10-10");
            DateTime d8 = DateTime.Parse("13/10/2020");
            DateTime d9 = DateTime.Parse("13-10-2020");
            DateTime d10 = DateTime.Parse("13-10-2020 22:00:50");
            DateTime d11 = DateTime.ParseExact("2020-10-11","yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("13/10/2020 22:06:55", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
