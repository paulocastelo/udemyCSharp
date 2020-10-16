using Microsoft.VisualBasic;
using System;

namespace DateTimeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) Hour: " + d.Hour);
            Console.WriteLine("4) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("5) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("6) LongDateString: " + d.ToLongDateString());
            Console.WriteLine("7) LongDateString: " + d.ToString("yyyy-dd-MM mm:HH:ss:fff"));

            DateTime d2 = d.AddDays(3.0);
            Console.WriteLine("8) AddDays: " + d2);
            Console.WriteLine("9) Subtract: " + d2.Subtract(d));

        }
    }
}
