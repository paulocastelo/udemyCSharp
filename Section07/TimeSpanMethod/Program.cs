using System;

namespace TimeSpanMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(0, 1, 30);
            TimeSpan t4 = new TimeSpan(1, 22, 13, 14);
            TimeSpan t5 = new TimeSpan(1, 22, 13, 14, 550);
            TimeSpan t6 = TimeSpan.FromDays(1.22);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t2.Ticks);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
