using System;

namespace TimeSpanProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            TimeSpan t4 = new TimeSpan(20, 10, 10, 53);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t4.Days);
            Console.WriteLine(t4.Hours);
            Console.WriteLine(t4.Minutes);
            Console.WriteLine(t4.Milliseconds);
            Console.WriteLine(t4.TotalDays);
            Console.WriteLine(t4.TotalHours);
            Console.WriteLine(t4.TotalMinutes);
            Console.WriteLine(t4.TotalSeconds);
            Console.WriteLine(t4.TotalMilliseconds);
            Console.WriteLine("+---------------------------------------+");
            TimeSpan t5 = new TimeSpan(7, 14, 21, 35);
            TimeSpan t6 = new TimeSpan(14,21,35,49);

            TimeSpan sum = t5.Add(t6);
            TimeSpan def = t5.Subtract(t6);
            Console.WriteLine(sum);
            Console.WriteLine(def);
        }
    }
}
